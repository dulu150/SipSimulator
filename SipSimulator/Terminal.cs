
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SipSimulator
{
    class Terminal
    {
        private Sender sendClient;
        private string ViaHeader;

        public Terminal(string protocal, string localip, string localport, string remoteip, string remoteport)
        {
            sendClient = SenderFactory.CreateSender(protocal, localip, localport, remoteip, remoteport);
            if (sendClient == null)
                Log.RecordErr("Socket启动失败,请检查配置");
            else
                Log.RecordErr("Socket启动成功了:" + localip + ":" + localport);

            ViaHeader = "";
        }

        public string Send(string textWaitToSend)
        {
            textWaitToSend = SIPMmessageAssembler.SetViaHeaderToSipMessage(textWaitToSend, ViaHeader);
            sendClient.Send(textWaitToSend);
            return textWaitToSend;
        }

        public string Send(string fileWaitToSendPath, MsgSourceType msgsource)
        {
            if (msgsource != MsgSourceType.FROM_FILE)
                return "";

            string sendstring = SIPMmessageAssembler.GetSipMessageFromFile(fileWaitToSendPath);
            if (sendstring.Length <= 0)
            {
                Log.RecordErr("待发送的SIP消息无效,请检查SIP消息");
                return "待发送的SIP消息无效,请检查SIP消息";
            }

            sendstring = SIPMmessageAssembler.SetViaHeaderToSipMessage(sendstring, ViaHeader);
            sendClient.Send(sendstring);
            return sendstring;
        }

        public string Recv()
        {
            string recvString = sendClient.Recv();
            ViaHeader = SIPMmessageAssembler.GetViaHeaderFromSipMessage(recvString);

            return recvString;
        }

        public string Recv(string msgTypeWaitToRecv, MsgSourceType msgsource)
        {
            if (msgsource != MsgSourceType.FROM_MSGTYPE)
                return "";

            string[] alltext;
            string recieveString;
            do 
            {
                recieveString = sendClient.Recv();
                alltext = recieveString.Split(new char[] { '\r', '\n' });
            } while (alltext[0].IndexOf(msgTypeWaitToRecv) < 0 || alltext[0].IndexOf("SIP/2.0") < 0);

            ViaHeader = SIPMmessageAssembler.GetViaHeaderFromSipMessage(recieveString);
            return recieveString;
        }

        public void Stop()
        {
            sendClient.RealeaseAllResource();
        }
    }
}
