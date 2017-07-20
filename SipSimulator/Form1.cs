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
            myapp.GetSipMessageList("CallerMsgPlan.txt", CallRole.Caller);
            myapp.GetSipMessageList("CalleeMsgPlan.txt", CallRole.Callee);

            Config config = new Config("config.txt");

            txtcallerip.Text = config.callerLocalIp; txtcallerport.Text = config.callerLocalPort;
            txtcallerremoteip.Text = config.callerRemoteIp; txtcallerremoteport.Text = config.callerRemotePort;
            txtcalleeip.Text = config.calleeLocalIp; txtcalleeport.Text = config.calleeLocalPort;
            txtcalleeremoteip.Text = config.calleeRemoteIp; txtcalleeremoteport.Text = config.calleeRemotePort;

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
            SIPMmessageAssembler.DeleteHistoryInfo();

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
