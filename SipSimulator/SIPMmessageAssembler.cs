using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SipSimulator
{
    class SIPMmessageAssembler
    {
        public static string GetSipMessageFromFile(string filepath)
        {
            string[] AllText = File.ReadAllLines(filepath);
            string sendString = "";

            for (int i = 0; i < AllText.Length - 1; i++)
            {
                sendString += AllText[i] + "\r\n";
            }
            sendString += AllText[AllText.Length - 1] + "\r\n";

            return sendString;
        }

        public static string GetViaHeaderFromSipMessage(string sipMessage)
        {
            string[] AllText = sipMessage.Split(new char[]{'\r', '\n'});

            foreach (string line in AllText)
            {
                if (line.IndexOf("Via:") >= 0)
                    return line;
            }

            return "";
        }

        public static string SetViaHeaderToSipMessage(string sipMessage, string viaHeader)
        {
            if (viaHeader.Length <= 0)
                return sipMessage;

            string[] AllText = sipMessage.Split(new char[] { '\r', '\n' });
            string sipMessageAfterMod = "";

            foreach (string line in AllText)
            {
                if (line.IndexOf("Via:") >= 0)
                    sipMessageAfterMod += viaHeader + Environment.NewLine;
                else if (line.StartsWith("\r\n") || line.Length <= 0)
                    continue;
                else
                    sipMessageAfterMod += line + Environment.NewLine;
            }
            sipMessageAfterMod +=  Environment.NewLine;
            return sipMessageAfterMod;
        }

        public static void ConverPtmfToSipMsg(string filepath, string callerIp, string calleeIp)
        {
            if (!File.Exists(filepath))
            {
                Log.PrintTrace("Ptmf file doesn't exist!!!", CallRole.Invalidrole);
                return;
            }

            if (callerIp.Split(new char[] { '.' }).Length != 4)
            {
                Log.PrintTrace("callerIp is Invalid when decoding Ptmf file!!!", CallRole.Invalidrole);
                return;
            }

            if (calleeIp.Split(new char[] { '.' }).Length != 4)
            {
                Log.PrintTrace("calleeIp is Invalid when decoding Ptmf file!!!", CallRole.Invalidrole);
                return;
            }

            SIPMessageUnit smu = new SIPMessageUnit();
            bool bfindmsg = false;
            bool bmsgend = false;
            foreach (string line in File.ReadAllLines(filepath))
            {
                if (line.IndexOf("[No.") >= 0)
                {
                    smu.Export(); smu.Clear();
                    bfindmsg = false; bmsgend = false;
                }

                if (line.IndexOf("Source Address") >= 0 && line.IndexOf(callerIp) >= 0)
                {
                    smu.SetRole(CallRole.Caller); smu.SetMsgDirection(MsgDirection.SEND);
                }

                if (line.IndexOf("Destination Address") >= 0 && line.IndexOf(callerIp) >= 0)
                {
                    smu.SetRole(CallRole.Caller); smu.SetMsgDirection(MsgDirection.RECV);
                }

                if (line.IndexOf("Source Address") >= 0 && line.IndexOf(calleeIp) >= 0)
                {
                    smu.SetRole(CallRole.Callee); smu.SetMsgDirection(MsgDirection.SEND);
                }

                if (line.IndexOf("Destination Address") >= 0 && line.IndexOf(calleeIp) >= 0)
                {
                    smu.SetRole(CallRole.Callee); smu.SetMsgDirection(MsgDirection.RECV);
                }

                if (line.IndexOf("Message Type") >= 0)
                {
                    string[] temp = line.Split(new char[] { ']' });
                    smu.SetMessageType(temp[1].Trim().Replace(' ', '_'));
                }

                if (line.IndexOf("SIP/2.0") >= 0 && line.IndexOf("]") < 0)
                    bfindmsg = true;

                if (line.IndexOf("===") >= 0)
                    bmsgend = true;

                if (bfindmsg == true && bmsgend == false)
                {
                    smu.AddToMessageContent(line);
                } 
            }
        }
    }

    class SIPMessageUnit
    {
        public CallRole role;
        public MsgDirection msgdirect;
        public string messagecontent;
        public string messageType;

        public SIPMessageUnit()
        {
            this.Clear();
        }

        public void Clear()
        {
            role = CallRole.Invalidrole; 
            msgdirect = MsgDirection.INVALIDMSGDIRECTION; 
            messagecontent = "";
            messageType = "";
        }

        public void Set(CallRole role, MsgDirection msgdirect, string messagecontent, string messageType, string localIp)
        {
            SetRole(role);
            SetMsgDirection(msgdirect);
            SetMessageContent(messagecontent);
            SetMessageType(messageType);
        }

        public void SetRole(CallRole role)
        {
            this.role = role;
        }

        public void SetMsgDirection(MsgDirection msgdirect)
        {
            this.msgdirect = msgdirect;
        }

        public void SetMessageContent(string messagecontent)
        {
            this.messagecontent = messagecontent;
        }

        public void AddToMessageContent(string messagecontent)
        {
            this.messagecontent += messagecontent + Environment.NewLine;
        }


        public void SetMessageType(string messageType)
        {
            this.messageType = messageType;
        }

        public void Export()
        {
            if (IsValid() == false) return;

            AddToMsgPlan();
            AddToMsgBluePrints();
        }

        void AddToMsgPlan()
        {
            if (!File.Exists(role.ToString() + "MsgPlan.txt"))
            {
                File.Create(role.ToString() + "MsgPlan.txt").Close();
            }
            File.AppendAllText(role.ToString() + "MsgPlan.txt", msgdirect.ToString() + " " + role.ToString() + "_" + messageType + ".txt" + Environment.NewLine);
        }

        void AddToMsgBluePrints()
        {
            if (!File.Exists(role.ToString() + "MsgBluePrints\\" + role.ToString() + "_" + messageType + ".txt"))
            {
                File.Create(role.ToString() + "MsgBluePrints\\" + role.ToString() + "_" + messageType + ".txt").Close();
            }
            File.AppendAllText(role.ToString() + "MsgBluePrints\\" + role.ToString() + "_" + messageType + ".txt", messagecontent);
        }

        bool IsValid()
        {
            if (role >= CallRole.Invalidrole) return false;

            if (msgdirect >= MsgDirection.INVALIDMSGDIRECTION) return false;

            if (messagecontent.IndexOf("Call-ID:") < 0) return false;

            if (messageType.Length <= 0) return false;

            return true;
        }

    }
}
