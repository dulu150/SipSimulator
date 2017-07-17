using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SipSimulator
{
    class Log
    {
        public static void RecordErr(string err)
        {
            MessageBox.Show(err);
        }

        public static void PrintTrace(string err, CallRole role)
        {
            if (role == CallRole.Caller)
                File.AppendAllText("callerlog.txt", err + Environment.NewLine);
            else if (role == CallRole.Callee)
                File.AppendAllText("calleelog.txt", err + Environment.NewLine);
            else
                File.AppendAllText("commonlog.txt", err + Environment.NewLine);
        }
    }
}
