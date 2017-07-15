using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace udptest
{
    class Log
    {
        public static void RecordErr(string err)
        {
            MessageBox.Show(err);

        }

        public static void PrintTrace(string err)
        {
            File.AppendAllText("D:\\log.txt", err + Environment.NewLine);
        }
    }
}
