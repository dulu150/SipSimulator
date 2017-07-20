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
                File.AppendAllText("Log\\callerlog.txt", err + Environment.NewLine);
            else if (role == CallRole.Callee)
                File.AppendAllText("Log\\calleelog.txt", err + Environment.NewLine);
            else
                File.AppendAllText("Log\\commonlog.txt", err + Environment.NewLine);
        }
    }
}
