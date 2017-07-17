using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace SipSimulator
{
    abstract class Sender
    {
        public abstract void Send(string textWaitToSend);

        public abstract string Recv();

        public abstract void RealeaseAllResource();
    }

    class UdpSender : Sender
    {
        UdpClient client;
        IPEndPoint remotePoint;
        IPEndPoint localPoint;

        public UdpSender(string localip, string localport, string remoteip, string remoteport)
        {
            IPAddress remoteIP = IPAddress.Parse(remoteip);
            int remotePort = int.Parse(remoteport);
            remotePoint = new IPEndPoint(remoteIP, remotePort);

            IPAddress localIP = IPAddress.Parse(localip);
            int localPort = int.Parse(localport);
            localPoint = new IPEndPoint(localIP, localPort);

            client = new UdpClient(localPoint);
        }

        public override void Send(string textWaitToSend)
        {
            byte[] sendData = null;
            sendData = Encoding.Default.GetBytes(textWaitToSend);
            Log.PrintTrace(localPoint.ToString() + ":send msg:" + textWaitToSend, CallRole.Invalidrole);
 
            client.Send(sendData, sendData.Length, remotePoint);
        }

        public override string Recv()
        {
            string receiveString = "";
            
            bool recvFinished = false;
            while (false == recvFinished)
            {
                string recvbuffer = "";
                byte[] receiveData = null;

                receiveData = client.Receive(ref remotePoint);
                recvbuffer = Encoding.Default.GetString(receiveData);
                receiveString += recvbuffer;
                if (recvbuffer.EndsWith("\r\n"))
                    recvFinished = true;
            }
            Log.PrintTrace("Msg from " + remotePoint.ToString() + " delimitates finish:" + receiveString, CallRole.Invalidrole);
            return receiveString;
        }

        public override void RealeaseAllResource()
        {
            client.Close();
        }
    }
}
