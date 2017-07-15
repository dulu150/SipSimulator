using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SipSimulator
{
    class SenderFactory
    {
        public static Sender CreateSender(string protocal, string localip, string localport, string remoteip, string remoteport)
        {
            if (protocal.Equals("UDP"))
            {
                return new UdpSender(localip, localport, remoteip, remoteport);
            }
            else
            {
                return null;
            }
        }
    }
}
