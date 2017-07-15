using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SipSimulator
{
    public partial class Form1 : Form
    {
        Director myapp = new Director();
        Terminal caller;
        Terminal callee;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myapp.GetSipMessageList("callermsgtemplate.txt", CallRole.Caller);
            myapp.GetSipMessageList("calleemsgtemplate.txt", CallRole.Callee);

            txtcallerip.Text = "127.0.0.1"; txtcallerport.Text = "12345";
            txtcalleeip.Text = "127.0.0.1"; txtcalleeport.Text = "8848";

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnCreatSocket_Click(object sender, EventArgs e)
        {
            caller = new Terminal("UDP", txtcallerip.Text, txtcallerport.Text, txtcalleeip.Text, txtcalleeport.Text);
            callee = new Terminal("UDP", txtcalleeip.Text, txtcalleeport.Text, txtcallerip.Text, txtcallerport.Text);
        }

        private void btnCallStart_Click(object sender, EventArgs e)
        {
            myapp.caller = caller;
            myapp.callee = callee;
            myapp.callertrace = txtCallerTrace;
            myapp.calleetrace = txtCalleeTrace;

            myapp.Run();
        }

        private void btnCallStop_Click(object sender, EventArgs e)
        {
            myapp.Stop();
        }
    }
}
