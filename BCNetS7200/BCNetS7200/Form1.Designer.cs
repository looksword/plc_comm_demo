namespace BCNetS7200
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
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Area = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.TxtLength = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.TxtAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.WriteBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.TxtDump = new System.Windows.Forms.TextBox();
            this.TxtTime = new System.Windows.Forms.TextBox();
            this.SendByte = new System.Windows.Forms.TextBox();
            this.RecvByte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(122, 7);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(29, 12);
            this.Label2.TabIndex = 41;
            this.Label2.Text = "Port";
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(122, 24);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(44, 21);
            this.TxtPort.TabIndex = 39;
            this.TxtPort.Text = "1099";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 12);
            this.Label1.TabIndex = 40;
            this.Label1.Text = "IP Address";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(12, 24);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(100, 21);
            this.TxtIP.TabIndex = 38;
            this.TxtIP.Text = "192.168.1.188";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Enabled = false;
            this.DisconnectBtn.Location = new System.Drawing.Point(176, 26);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(100, 21);
            this.DisconnectBtn.TabIndex = 43;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(176, 3);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(100, 21);
            this.ConnectBtn.TabIndex = 42;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(286, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 75;
            this.label15.Text = "Area";
            // 
            // Area
            // 
            this.Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Area.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.FormattingEnabled = true;
            this.Area.Items.AddRange(new object[] {
            "I",
            "Q",
            "V",
            "M"});
            this.Area.Location = new System.Drawing.Point(287, 23);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(132, 22);
            this.Area.TabIndex = 74;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(502, 5);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(41, 12);
            this.label38.TabIndex = 85;
            this.label38.Text = "Length";
            // 
            // TxtLength
            // 
            this.TxtLength.Location = new System.Drawing.Point(500, 24);
            this.TxtLength.Name = "TxtLength";
            this.TxtLength.Size = new System.Drawing.Size(57, 21);
            this.TxtLength.TabIndex = 84;
            this.TxtLength.Text = "1";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(433, 5);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(47, 12);
            this.Label7.TabIndex = 83;
            this.Label7.Text = "Address";
            // 
            // TxtAddr
            // 
            this.TxtAddr.Location = new System.Drawing.Point(431, 24);
            this.TxtAddr.Name = "TxtAddr";
            this.TxtAddr.Size = new System.Drawing.Size(57, 21);
            this.TxtAddr.TabIndex = 82;
            this.TxtAddr.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 87;
            this.label3.Text = "Value";
            // 
            // TxtValue
            // 
            this.TxtValue.Location = new System.Drawing.Point(571, 24);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(57, 21);
            this.TxtValue.TabIndex = 86;
            this.TxtValue.Text = "0";
            // 
            // WriteBtn
            // 
            this.WriteBtn.Location = new System.Drawing.Point(781, 15);
            this.WriteBtn.Name = "WriteBtn";
            this.WriteBtn.Size = new System.Drawing.Size(128, 30);
            this.WriteBtn.TabIndex = 89;
            this.WriteBtn.Text = "Write";
            this.WriteBtn.UseVisualStyleBackColor = true;
            this.WriteBtn.Click += new System.EventHandler(this.WriteBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(641, 15);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(128, 30);
            this.ReadBtn.TabIndex = 88;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // TxtDump
            // 
            this.TxtDump.BackColor = System.Drawing.Color.White;
            this.TxtDump.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDump.ForeColor = System.Drawing.Color.Black;
            this.TxtDump.Location = new System.Drawing.Point(12, 51);
            this.TxtDump.Multiline = true;
            this.TxtDump.Name = "TxtDump";
            this.TxtDump.ReadOnly = true;
            this.TxtDump.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDump.Size = new System.Drawing.Size(897, 211);
            this.TxtDump.TabIndex = 90;
            // 
            // TxtTime
            // 
            this.TxtTime.BackColor = System.Drawing.Color.White;
            this.TxtTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtTime.ForeColor = System.Drawing.Color.Black;
            this.TxtTime.Location = new System.Drawing.Point(0, 354);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.ReadOnly = true;
            this.TxtTime.Size = new System.Drawing.Size(923, 21);
            this.TxtTime.TabIndex = 91;
            // 
            // SendByte
            // 
            this.SendByte.Location = new System.Drawing.Point(12, 280);
            this.SendByte.Name = "SendByte";
            this.SendByte.Size = new System.Drawing.Size(897, 21);
            this.SendByte.TabIndex = 92;
            // 
            // RecvByte
            // 
            this.RecvByte.Location = new System.Drawing.Point(12, 317);
            this.RecvByte.Name = "RecvByte";
            this.RecvByte.Size = new System.Drawing.Size(897, 21);
            this.RecvByte.TabIndex = 93;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 375);
            this.Controls.Add(this.RecvByte);
            this.Controls.Add(this.SendByte);
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.TxtDump);
            this.Controls.Add(this.WriteBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.TxtLength);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TxtAddr);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtPort;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtIP;
        internal System.Windows.Forms.Button DisconnectBtn;
        internal System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox Area;
        internal System.Windows.Forms.Label label38;
        internal System.Windows.Forms.TextBox TxtLength;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox TxtAddr;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox TxtValue;
        internal System.Windows.Forms.Button WriteBtn;
        internal System.Windows.Forms.Button ReadBtn;
        internal System.Windows.Forms.TextBox TxtDump;
        internal System.Windows.Forms.TextBox TxtTime;
        private System.Windows.Forms.TextBox SendByte;
        private System.Windows.Forms.TextBox RecvByte;
    }
}

