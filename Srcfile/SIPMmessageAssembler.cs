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
    }
}
