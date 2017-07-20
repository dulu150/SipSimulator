namespace SipSimulator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCallStart = new System.Windows.Forms.Button();
            this.btnCallStop = new System.Windows.Forms.Button();
            this.txtCallerTrace = new System.Windows.Forms.TextBox();
            this.txtCalleeTrace = new System.Windows.Forms.TextBox();
            this.txtcallerip = new System.Windows.Forms.TextBox();
            this.txtcalleeip = new System.Windows.Forms.TextBox();
            this.txtcallerport = new System.Windows.Forms.TextBox();
            this.txtcalleeport = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreatSocket = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcallerremoteip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcallerremoteport = new System.Windows.Forms.TextBox();
            this.txtcalleeremoteip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcalleeremoteport = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnptmfanalyzestart = new System.Windows.Forms.Button();
            this.txnptmfcallerip = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txnptmfcalleeip = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtptmfpath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCallStart
            // 
            this.btnCallStart.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCallStart.Location = new System.Drawing.Point(12, 396);
            this.btnCallStart.Name = "btnCallStart";
            this.btnCallStart.Size = new System.Drawing.Size(684, 61);
            this.btnCallStart.TabIndex = 0;
            this.btnCallStart.Text = "开始呼叫";
            this.btnCallStart.UseVisualStyleBackColor = true;
            this.btnCallStart.Click += new System.EventHandler(this.btnCallStart_Click);
            // 
            // btnCallStop
            // 
            this.btnCallStop.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCallStop.Location = new System.Drawing.Point(12, 472);
            this.btnCallStop.Name = "btnCallStop";
            this.btnCallStop.Size = new System.Drawing.Size(684, 61);
            this.btnCallStop.TabIndex = 2;
            this.btnCallStop.Text = "停止呼叫";
            this.btnCallStop.UseVisualStyleBackColor = true;
            this.btnCallStop.Click += new System.EventHandler(this.btnCallStop_Click);
            // 
            // txtCallerTrace
            // 
            this.txtCallerTrace.Location = new System.Drawing.Point(12, 22);
            this.txtCallerTrace.Multiline = true;
            this.txtCallerTrace.Name = "txtCallerTrace";
            this.txtCallerTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCallerTrace.Size = new System.Drawing.Size(334, 302);
            this.txtCallerTrace.TabIndex = 4;
            this.txtCallerTrace.Text = "主叫消息跟踪：";
            // 
            // txtCalleeTrace
            // 
            this.txtCalleeTrace.Location = new System.Drawing.Point(362, 22);
            this.txtCalleeTrace.Multiline = true;
            this.txtCalleeTrace.Name = "txtCalleeTrace";
            this.txtCalleeTrace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCalleeTrace.Size = new System.Drawing.Size(334, 302);
            this.txtCalleeTrace.TabIndex = 5;
            this.txtCalleeTrace.Text = "被叫消息跟踪：";
            // 
            // txtcallerip
            // 
            this.txtcallerip.Location = new System.Drawing.Point(12, 342);
            this.txtcallerip.Name = "txtcallerip";
            this.txtcallerip.Size = new System.Drawing.Size(78, 21);
            this.txtcallerip.TabIndex = 6;
            // 
            // txtcalleeip
            // 
            this.txtcalleeip.Location = new System.Drawing.Point(618, 336);
            this.txtcalleeip.Name = "txtcalleeip";
            this.txtcalleeip.Size = new System.Drawing.Size(78, 21);
            this.txtcalleeip.TabIndex = 7;
            // 
            // txtcallerport
            // 
            this.txtcallerport.Location = new System.Drawing.Point(12, 369);
            this.txtcallerport.Name = "txtcallerport";
            this.txtcallerport.Size = new System.Drawing.Size(66, 21);
            this.txtcallerport.TabIndex = 8;
            // 
            // txtcalleeport
            // 
            this.txtcalleeport.Location = new System.Drawing.Point(630, 363);
            this.txtcalleeport.Name = "txtcalleeport";
            this.txtcalleeport.Size = new System.Drawing.Size(66, 21);
            this.txtcalleeport.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "主叫IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "被叫IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "主叫PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "被叫PORT";
            // 
            // btnCreatSocket
            // 
            this.btnCreatSocket.Location = new System.Drawing.Point(312, 345);
            this.btnCreatSocket.Name = "btnCreatSocket";
            this.btnCreatSocket.Size = new System.Drawing.Size(83, 39);
            this.btnCreatSocket.TabIndex = 14;
            this.btnCreatSocket.Text = "建立连接";
            this.btnCreatSocket.UseVisualStyleBackColor = true;
            this.btnCreatSocket.Click += new System.EventHandler(this.btnCreatSocket_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "对端IP";
            // 
            // txtcallerremoteip
            // 
            this.txtcallerremoteip.Location = new System.Drawing.Point(214, 339);
            this.txtcallerremoteip.Name = "txtcallerremoteip";
            this.txtcallerremoteip.Size = new System.Drawing.Size(78, 21);
            this.txtcallerremoteip.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "对端PORT";
            // 
            // txtcallerremoteport
            // 
            this.txtcallerremoteport.Location = new System.Drawing.Point(226, 369);
            this.txtcallerremoteport.Name = "txtcallerremoteport";
            this.txtcallerremoteport.Size = new System.Drawing.Size(66, 21);
            this.txtcallerremoteport.TabIndex = 18;
            // 
            // txtcalleeremoteip
            // 
            this.txtcalleeremoteip.Location = new System.Drawing.Point(418, 336);
            this.txtcalleeremoteip.Name = "txtcalleeremoteip";
            this.txtcalleeremoteip.Size = new System.Drawing.Size(78, 21);
            this.txtcalleeremoteip.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "对端IP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "对端PORT";
            // 
            // txtcalleeremoteport
            // 
            this.txtcalleeremoteport.Location = new System.Drawing.Point(418, 369);
            this.txtcalleeremoteport.Name = "txtcalleeremoteport";
            this.txtcalleeremoteport.Size = new System.Drawing.Size(66, 21);
            this.txtcalleeremoteport.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtptmfpath);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txnptmfcalleeip);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txnptmfcallerip);
            this.groupBox1.Controls.Add(this.btnptmfanalyzestart);
            this.groupBox1.Location = new System.Drawing.Point(711, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 511);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "跟踪解析";
            // 
            // btnptmfanalyzestart
            // 
            this.btnptmfanalyzestart.Location = new System.Drawing.Point(90, 159);
            this.btnptmfanalyzestart.Name = "btnptmfanalyzestart";
            this.btnptmfanalyzestart.Size = new System.Drawing.Size(75, 23);
            this.btnptmfanalyzestart.TabIndex = 0;
            this.btnptmfanalyzestart.Text = "开始分析";
            this.btnptmfanalyzestart.UseVisualStyleBackColor = true;
            this.btnptmfanalyzestart.Click += new System.EventHandler(this.btnptmfanalyzestart_Click);
            // 
            // txnptmfcallerip
            // 
            this.txnptmfcallerip.Location = new System.Drawing.Point(66, 26);
            this.txnptmfcallerip.Name = "txnptmfcallerip";
            this.txnptmfcallerip.Size = new System.Drawing.Size(131, 21);
            this.txnptmfcallerip.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "主叫IP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "被叫IP";
            // 
            // txnptmfcalleeip
            // 
            this.txnptmfcalleeip.Location = new System.Drawing.Point(66, 65);
            this.txnptmfcalleeip.Name = "txnptmfcalleeip";
            this.txnptmfcalleeip.Size = new System.Drawing.Size(131, 21);
            this.txnptmfcalleeip.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "文件路径";
            // 
            // txtptmfpath
            // 
            this.txtptmfpath.Location = new System.Drawing.Point(66, 107);
            this.txtptmfpath.Name = "txtptmfpath";
            this.txtptmfpath.Size = new System.Drawing.Size(131, 21);
            this.txtptmfpath.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtcalleeremoteport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcalleeremoteip);
            this.Controls.Add(this.txtcallerremoteport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcallerremoteip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreatSocket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcalleeport);
            this.Controls.Add(this.txtcallerport);
            this.Controls.Add(this.txtcalleeip);
            this.Controls.Add(this.txtcallerip);
            this.Controls.Add(this.txtCalleeTrace);
            this.Controls.Add(this.txtCallerTrace);
            this.Controls.Add(this.btnCallStop);
            this.Controls.Add(this.btnCallStart);
            this.Name = "Form1";
            this.Text = "SipSimulatro V1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCallStart;
        private System.Windows.Forms.Button btnCallStop;
        private System.Windows.Forms.TextBox txtCallerTrace;
        private System.Windows.Forms.TextBox txtCalleeTrace;
        private System.Windows.Forms.TextBox txtcallerip;
        private System.Windows.Forms.TextBox txtcalleeip;
        private System.Windows.Forms.TextBox txtcallerport;
        private System.Windows.Forms.TextBox txtcalleeport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreatSocket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcallerremoteip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcallerremoteport;
        private System.Windows.Forms.TextBox txtcalleeremoteip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcalleeremoteport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnptmfanalyzestart;
        private System.Windows.Forms.TextBox txnptmfcalleeip;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txnptmfcallerip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtptmfpath;
    }
}

