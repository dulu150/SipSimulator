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
    }
}
