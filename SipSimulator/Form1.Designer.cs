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
            this.SuspendLayout();
            // 
            // btnCallStart
            // 
            this.btnCallStart.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.btnCallStop.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.txtCallerTrace.Size = new System.Drawing.Size(334, 302);
            this.txtCallerTrace.TabIndex = 4;
            this.txtCallerTrace.Text = "主叫消息跟踪：";
            // 
            // txtCalleeTrace
            // 
            this.txtCalleeTrace.Location = new System.Drawing.Point(362, 22);
            this.txtCalleeTrace.Multiline = true;
            this.txtCalleeTrace.Name = "txtCalleeTrace";
            this.txtCalleeTrace.Size = new System.Drawing.Size(334, 302);
            this.txtCalleeTrace.TabIndex = 5;
            this.txtCalleeTrace.Text = "被叫消息跟踪：";
            // 
            // txtcallerip
            // 
            this.txtcallerip.Location = new System.Drawing.Point(12, 342);
            this.txtcallerip.Name = "txtcallerip";
            this.txtcallerip.Size = new System.Drawing.Size(167, 21);
            this.txtcallerip.TabIndex = 6;
            // 
            // txtcalleeip
            // 
            this.txtcalleeip.Location = new System.Drawing.Point(529, 342);
            this.txtcalleeip.Name = "txtcalleeip";
            this.txtcalleeip.Size = new System.Drawing.Size(167, 21);
            this.txtcalleeip.TabIndex = 7;
            // 
            // txtcallerport
            // 
            this.txtcallerport.Location = new System.Drawing.Point(12, 369);
            this.txtcallerport.Name = "txtcallerport";
            this.txtcallerport.Size = new System.Drawing.Size(167, 21);
            this.txtcallerport.TabIndex = 8;
            // 
            // txtcalleeport
            // 
            this.txtcalleeport.Location = new System.Drawing.Point(529, 369);
            this.txtcalleeport.Name = "txtcalleeport";
            this.txtcalleeport.Size = new System.Drawing.Size(167, 21);
            this.txtcalleeport.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "主叫IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "被叫IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "主叫PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 372);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 545);
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
    }
}

