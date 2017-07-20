using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SipSimulator
{
    class Config
    {
        public string callerLocalIp;
        public string callerLocalPort;

        public string callerRemoteIp;
        public string callerRemotePort;

        public string calleeLocalIp;
        public string calleeLocalPort;

        public string calleeRemoteIp;
        public string calleeRemotePort;

        public Config(string filepath)
        {
            foreach (string line in File.ReadAllLines(filepath))
            {
                GetCallerLocalIp(line);
                GetCallerRemoteIp(line);
                GetCalleeLocalIp(line);
                GetCalleeRemoteIp(line);
            }
        }

        void GetCallerLocalIp(string line)
        {
            if (line.IndexOf("Caller-LOCAL--IP:PORT") < 0)
            {
                return;
            }
            else
            {
                string[] temp = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length < 3)
                    return;

                callerLocalIp = temp[1];
                callerLocalPort = temp[2];
            }
        }

        void GetCallerRemoteIp(string line)
        {
            if (line.IndexOf("Caller-Remote-IP:PORT") < 0)
            {
                return;
            }
            else
            {
                string[] temp = line.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length < 3)
                    return;

                callerRemoteIp = temp[1];
                callerRemotePort = temp[2];
            }
        }

        void GetCalleeLocalIp(string line)
        {
            if (line.IndexOf("Callee-LOCAL--IP:PORT ") < 0)
            {
                return;
            }
            else
            {
                string[] temp = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length < 3)
                    return;

                calleeLocalIp = temp[1];
                calleeLocalPort = temp[2];
            }
        }

        void GetCalleeRemoteIp(string line)
        {
            if (line.IndexOf("Callee-Remote-IP:PORT") < 0)
            {
                return;
            }
            else
            {
                string[] temp = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (temp.Length < 3)
                    return;

                calleeRemoteIp = temp[1];
                calleeRemotePort = temp[2];
            }
        }
    }
}
