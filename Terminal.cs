using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SipSimulator
{
    class Terminal
    {
        private Sender sendClient;

        public Terminal(string protocal, string localip, string localport, string remoteip, string remoteport)
        {
            sendClient = SenderFactory.CreateSender(protocal, localip, localport, remoteip, remoteport);
            if (sendClient == null)
                MessageBox.Show("Socket启动失败,请检查配置");    
        }

        public void Send(string textWaitToSend)
        {
            sendClient.Send(textWaitToSend);
        }

        public void Send(string fileWaitToSendPath, bool readFile)
        {
            string sendstring = SIPMmessageAssembler.GetSipMessageFromFile(fileWaitToSendPath);
            if (sendstring.Length <= 0)
                MessageBox.Show("待发送的SIP消息无效,请检查SIP消息");

            sendClient.Send(sendstring);
        }

        public string Recv()
        {
            return "";
        }

        public bool Recv(string msgTypeWaitToRecv)
        {
            return false;
        }
    }
}
