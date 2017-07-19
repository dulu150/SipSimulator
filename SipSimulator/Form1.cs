using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
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
            txtcallerremoteip.Text = "127.0.0.1"; txtcallerremoteport.Text = "8848";
            txtcalleeip.Text = "127.0.0.1"; txtcalleeport.Text = "8848";
            txtcalleeremoteip.Text = "127.0.0.1"; txtcalleeremoteport.Text = "12345";

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnCreatSocket_Click(object sender, EventArgs e)
        {
            caller = new Terminal("UDP", txtcallerip.Text, txtcallerport.Text, txtcallerremoteip.Text, txtcallerremoteport.Text);
            Log.PrintTrace("caller create socket:" + txtcallerip.Text + ":" + txtcallerport.Text + "--" + txtcallerremoteip.Text + ":" + txtcallerremoteport.Text, CallRole.Caller);
            callee = new Terminal("UDP", txtcalleeip.Text, txtcalleeport.Text, txtcalleeremoteip.Text, txtcalleeremoteport.Text);
            Log.PrintTrace("callee create socket:" + txtcalleeip.Text + ":" + txtcalleeport.Text + "--" + txtcalleeremoteip.Text + ":" + txtcalleeremoteport.Text, CallRole.Callee);
        }

        private void btnCallStart_Click(object sender, EventArgs e)
        {
            myapp.caller = caller;
            myapp.callee = callee;
            myapp.callertrace = txtCallerTrace;
            myapp.calleetrace = txtCalleeTrace;

            myapp.SetInitFinishFlag(true);
            myapp.Run();
        }

        private void btnCallStop_Click(object sender, EventArgs e)
        {
            myapp.Stop();
            myapp.SetInitFinishFlag(false);
        }

        private void btnptmfanalyzestart_Click(object sender, EventArgs e)
        {
            if (txnptmfcallerip.Text.Split(new char[] { '.' }).Length != 4)
            {
                MessageBox.Show("主叫IP无效");
                return;
            }

            if (txnptmfcalleeip.Text.Split(new char[] { '.' }).Length != 4)
            {
                MessageBox.Show("被叫IP无效");
                return;
            }

            if (txtptmfpath.Text.Length <= 0)
            {
                MessageBox.Show("跟踪文件路径无效");
                return;
            }

            if (!File.Exists(txtptmfpath.Text))
            {
                MessageBox.Show("跟踪文件不存在，请检查路径");
                return;
            }

            SIPMmessageAssembler.ConverPtmfToSipMsg(txtptmfpath.Text, txnptmfcallerip.Text, txnptmfcalleeip.Text);
            MessageBox.Show("解析完成");
        }
    }
}
