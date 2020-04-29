namespace S7_1500
{
    partial class S7_1500_Form
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
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtSlot = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtRack = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CBWLen = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CBArea = new System.Windows.Forms.ComboBox();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TxtDB = new System.Windows.Forms.TextBox();
            this.TxtDump = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.Offset = new System.Windows.Forms.TextBox();
            this.TextError = new System.Windows.Forms.TextBox();
            this.TxtToWrite = new System.Windows.Forms.TextBox();
            this.WriteBtn = new System.Windows.Forms.Button();
            this.bitValue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Enabled = false;
            this.DisconnectBtn.Location = new System.Drawing.Point(235, 36);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(100, 21);
            this.DisconnectBtn.TabIndex = 39;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(235, 12);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(100, 21);
            this.ConnectBtn.TabIndex = 36;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(174, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(29, 12);
            this.Label3.TabIndex = 38;
            this.Label3.Text = "Slot";
            // 
            // TxtSlot
            // 
            this.TxtSlot.Location = new System.Drawing.Point(174, 26);
            this.TxtSlot.Name = "TxtSlot";
            this.TxtSlot.Size = new System.Drawing.Size(44, 21);
            this.TxtSlot.TabIndex = 35;
            this.TxtSlot.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(118, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(29, 12);
            this.Label2.TabIndex = 37;
            this.Label2.Text = "Rack";
            // 
            // TxtRack
            // 
            this.TxtRack.Location = new System.Drawing.Point(118, 26);
            this.TxtRack.Name = "TxtRack";
            this.TxtRack.Size = new System.Drawing.Size(44, 21);
            this.TxtRack.TabIndex = 33;
            this.TxtRack.Text = "0";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 12);
            this.Label1.TabIndex = 34;
            this.Label1.Text = "IP Address";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(8, 26);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(100, 21);
            this.TxtIP.TabIndex = 32;
            this.TxtIP.Text = "192.168.0.1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(144, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 75;
            this.label17.Text = "WordLength";
            // 
            // CBWLen
            // 
            this.CBWLen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBWLen.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBWLen.FormattingEnabled = true;
            this.CBWLen.Items.AddRange(new object[] {
            "S7WLBit      0x01",
            "S7WLByte     0x02",
            "S7WLChar     0x03",
            "S7WLWord     0x04",
            "S7WLInt      0x05",
            "S7WLDWord    0x06",
            "S7WLDInt     0x07",
            "S7WLReal     0x08"});
            this.CBWLen.Location = new System.Drawing.Point(146, 88);
            this.CBWLen.Name = "CBWLen";
            this.CBWLen.Size = new System.Drawing.Size(142, 22);
            this.CBWLen.TabIndex = 74;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 73;
            this.label15.Text = "Area";
            // 
            // CBArea
            // 
            this.CBArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBArea.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBArea.FormattingEnabled = true;
            this.CBArea.Items.AddRange(new object[] {
            "S7AreaPE  0x81",
            "S7AreaPA  0x82",
            "S7AreaMK  0x83",
            "S7AreaDB  0x84"});
            this.CBArea.Location = new System.Drawing.Point(8, 88);
            this.CBArea.Name = "CBArea";
            this.CBArea.Size = new System.Drawing.Size(132, 22);
            this.CBArea.TabIndex = 72;
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(495, 88);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(97, 21);
            this.ReadBtn.TabIndex = 71;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(342, 71);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(53, 12);
            this.Label7.TabIndex = 70;
            this.Label7.Text = "Elements";
            // 
            // TxtSize
            // 
            this.TxtSize.Location = new System.Drawing.Point(345, 90);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(57, 21);
            this.TxtSize.TabIndex = 68;
            this.TxtSize.Text = "12";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(291, 71);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(17, 12);
            this.Label6.TabIndex = 69;
            this.Label6.Text = "DB";
            // 
            // TxtDB
            // 
            this.TxtDB.Location = new System.Drawing.Point(294, 90);
            this.TxtDB.Name = "TxtDB";
            this.TxtDB.Size = new System.Drawing.Size(45, 21);
            this.TxtDB.TabIndex = 67;
            this.TxtDB.Text = "1";
            // 
            // TxtDump
            // 
            this.TxtDump.BackColor = System.Drawing.Color.White;
            this.TxtDump.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDump.ForeColor = System.Drawing.Color.Black;
            this.TxtDump.Location = new System.Drawing.Point(8, 163);
            this.TxtDump.Multiline = true;
            this.TxtDump.Name = "TxtDump";
            this.TxtDump.ReadOnly = true;
            this.TxtDump.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDump.Size = new System.Drawing.Size(584, 259);
            this.TxtDump.TabIndex = 76;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(405, 71);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(41, 12);
            this.label38.TabIndex = 81;
            this.label38.Text = "Offset";
            // 
            // Offset
            // 
            this.Offset.Location = new System.Drawing.Point(408, 90);
            this.Offset.Name = "Offset";
            this.Offset.Size = new System.Drawing.Size(57, 21);
            this.Offset.TabIndex = 80;
            this.Offset.Text = "0";
            // 
            // TextError
            // 
            this.TextError.BackColor = System.Drawing.Color.White;
            this.TextError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextError.ForeColor = System.Drawing.Color.Black;
            this.TextError.Location = new System.Drawing.Point(0, 439);
            this.TextError.Name = "TextError";
            this.TextError.ReadOnly = true;
            this.TextError.Size = new System.Drawing.Size(597, 21);
            this.TextError.TabIndex = 82;
            // 
            // TxtToWrite
            // 
            this.TxtToWrite.Location = new System.Drawing.Point(97, 127);
            this.TxtToWrite.Name = "TxtToWrite";
            this.TxtToWrite.Size = new System.Drawing.Size(242, 21);
            this.TxtToWrite.TabIndex = 83;
            this.TxtToWrite.Text = "41D99996";
            // 
            // WriteBtn
            // 
            this.WriteBtn.Location = new System.Drawing.Point(495, 126);
            this.WriteBtn.Name = "WriteBtn";
            this.WriteBtn.Size = new System.Drawing.Size(97, 21);
            this.WriteBtn.TabIndex = 84;
            this.WriteBtn.Text = "Write";
            this.WriteBtn.UseVisualStyleBackColor = true;
            this.WriteBtn.Click += new System.EventHandler(this.WriteBtn_Click);
            // 
            // bitValue
            // 
            this.bitValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitValue.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitValue.FormattingEnabled = true;
            this.bitValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.bitValue.Location = new System.Drawing.Point(394, 126);
            this.bitValue.Name = "bitValue";
            this.bitValue.Size = new System.Drawing.Size(95, 22);
            this.bitValue.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 86;
            this.label4.Text = "用字节表示实数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 87;
            this.label5.Text = "开关量";
            // 
            // S7_1500_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 460);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bitValue);
            this.Controls.Add(this.WriteBtn);
            this.Controls.Add(this.TxtToWrite);
            this.Controls.Add(this.TextError);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.Offset);
            this.Controls.Add(this.TxtDump);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CBWLen);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CBArea);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TxtDB);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtSlot);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtRack);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtIP);
            this.Name = "S7_1500_Form";
            this.Text = "S7-1500";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button DisconnectBtn;
        internal System.Windows.Forms.Button ConnectBtn;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtSlot;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtRack;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CBWLen;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CBArea;
        internal System.Windows.Forms.Button ReadBtn;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox TxtSize;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TxtDB;
        internal System.Windows.Forms.TextBox TxtDump;
        internal System.Windows.Forms.Label label38;
        internal System.Windows.Forms.TextBox Offset;
        internal System.Windows.Forms.TextBox TextError;
        internal System.Windows.Forms.TextBox TxtToWrite;
        internal System.Windows.Forms.Button WriteBtn;
        private System.Windows.Forms.ComboBox bitValue;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
    }
}

