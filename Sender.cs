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
        }

        public override void Send(string textWaitToSend)
        {
            byte[] sendData = null;
            sendData = Encoding.Default.GetBytes(textWaitToSend);

            client = new UdpClient(localPoint);
            client.Send(sendData, sendData.Length, remotePoint);
            client.Close();
        }

        public override string Recv()
        {
            return "";
        }
    }
}
