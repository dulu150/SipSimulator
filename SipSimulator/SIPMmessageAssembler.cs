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
            if (!File.Exists(filepath)) Log.PrintTrace("Ptmf file doesn't exist!!!", CallRole.Invalidrole);

        }
    }

    class SIPMessageUnit
    {
        public CallRole role;
        public MsgDirection msgdirect;
        public string messagecontent;
        public string messageType;
        public string localIp;

        public void SIPMessageUnit()
        {
            this.Clear();
        }

        public void Clear()
        {
            role = CallRole.Invalidrole; 
            msgdirect = MsgDirection.INVALIDMSGDIRECTION; 
            messagecontent = "";
            messageType = "";
            localIp = "";
        }

        public void Set(CallRole role, MsgDirection msgdirect, string messagecontent, string messageType, string localIp)
        {
            SetRole(role);
            SetMsgDirection(msgdirect);
            SetMessageContent(messagecontent);
            SetMessageType(messageType);
            SetLocalIp(localIp);
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

        public void SetMessageType(string messageType)
        {
            this.messageType = messageType;
        }

        public void SetLocalIp(string localIp)
        {
            this.localIp = localIp;
        }

        public void Export()
        {
            if (IsValid() == false) return;

            AddToMsgPlan();
            AddToMsgBluePrints();
        }

        void AddToMsgPlan()
        {
            File.AppendAllText(role.ToString() + "MsgPlan.txt", msgdirect.ToString() + " " + role.ToString() + "_" + messageType + ".txt");
        }

        void AddToMsgBluePrints()
        {
            File.AppendAllText(role.ToString() + "MsgBluePrints\\" + role.ToString() + "_" + messageType + ".txt", messagecontent);
        }

        bool IsValid()
        {
            if (role >= CallRole.Invalidrole) return false;

            if (msgdirect >= MsgDirection.INVALIDMSGDIRECTION) return false;

            if (messagecontent.IndexOf("Call-ID:") < 0) return false;

            if (messageType.Length <= 0) return false;

            if (localIp.Split(new char[] { '.' }).Length != 3) return false;

            return true;
        }

    }
}
