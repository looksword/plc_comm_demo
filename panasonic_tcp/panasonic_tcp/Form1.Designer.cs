namespace panasonic_tcp
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bitValue = new System.Windows.Forms.ComboBox();
            this.write_value = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.return_value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.address_reduce = new System.Windows.Forms.Button();
            this.address_add = new System.Windows.Forms.Button();
            this.address_type = new System.Windows.Forms.ComboBox();
            this.count = new System.Windows.Forms.TextBox();
            this.address_ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.read = new System.Windows.Forms.Button();
            this.wirte = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Enabled = false;
            this.DisconnectBtn.Location = new System.Drawing.Point(182, 38);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(100, 21);
            this.DisconnectBtn.TabIndex = 47;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(182, 14);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(100, 21);
            this.ConnectBtn.TabIndex = 44;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(180, 18);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(0, 12);
            this.Label3.TabIndex = 46;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(124, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(29, 12);
            this.Label2.TabIndex = 45;
            this.Label2.Text = "Port";
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(124, 35);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(44, 21);
            this.TxtPort.TabIndex = 41;
            this.TxtPort.Text = "60001";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 12);
            this.Label1.TabIndex = 42;
            this.Label1.Text = "IP Address";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(14, 35);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(100, 21);
            this.TxtIP.TabIndex = 40;
            this.TxtIP.Text = "192.168.1.5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.bitValue);
            this.groupBox2.Controls.Add(this.write_value);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.return_value);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.address_reduce);
            this.groupBox2.Controls.Add(this.address_add);
            this.groupBox2.Controls.Add(this.address_type);
            this.groupBox2.Controls.Add(this.count);
            this.groupBox2.Controls.Add(this.address_);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.read);
            this.groupBox2.Controls.Add(this.wirte);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(16, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 353);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 89;
            this.label7.Text = "开关量";
            // 
            // bitValue
            // 
            this.bitValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitValue.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bitValue.FormattingEnabled = true;
            this.bitValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.bitValue.Location = new System.Drawing.Point(451, 133);
            this.bitValue.Name = "bitValue";
            this.bitValue.Size = new System.Drawing.Size(95, 22);
            this.bitValue.TabIndex = 88;
            // 
            // write_value
            // 
            this.write_value.Location = new System.Drawing.Point(244, 124);
            this.write_value.Name = "write_value";
            this.write_value.Size = new System.Drawing.Size(126, 33);
            this.write_value.TabIndex = 17;
            this.write_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "数值";
            // 
            // return_value
            // 
            this.return_value.Location = new System.Drawing.Point(55, 176);
            this.return_value.Multiline = true;
            this.return_value.Name = "return_value";
            this.return_value.ReadOnly = true;
            this.return_value.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.return_value.Size = new System.Drawing.Size(711, 160);
            this.return_value.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "返回";
            // 
            // address_reduce
            // 
            this.address_reduce.Location = new System.Drawing.Point(55, 82);
            this.address_reduce.Name = "address_reduce";
            this.address_reduce.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.address_reduce.Size = new System.Drawing.Size(20, 32);
            this.address_reduce.TabIndex = 6;
            this.address_reduce.Text = "<";
            this.address_reduce.UseVisualStyleBackColor = true;
            this.address_reduce.Click += new System.EventHandler(this.address_reduce_Click);
            // 
            // address_add
            // 
            this.address_add.Location = new System.Drawing.Point(161, 80);
            this.address_add.Name = "address_add";
            this.address_add.Size = new System.Drawing.Size(20, 32);
            this.address_add.TabIndex = 7;
            this.address_add.Text = ">";
            this.address_add.UseVisualStyleBackColor = true;
            this.address_add.Click += new System.EventHandler(this.address_add_Click);
            // 
            // address_type
            // 
            this.address_type.FormattingEnabled = true;
            this.address_type.Items.AddRange(new object[] {
            "D",
            "L",
            "X",
            "Y",
            "R",
            "LM",
            "T",
            "C"});
            this.address_type.Location = new System.Drawing.Point(55, 37);
            this.address_type.Name = "address_type";
            this.address_type.Size = new System.Drawing.Size(126, 33);
            this.address_type.TabIndex = 13;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(55, 124);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(126, 33);
            this.count.TabIndex = 6;
            this.count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // address_
            // 
            this.address_.Location = new System.Drawing.Point(81, 82);
            this.address_.Name = "address_";
            this.address_.Size = new System.Drawing.Size(74, 33);
            this.address_.TabIndex = 12;
            this.address_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address_.TextChanged += new System.EventHandler(this.address__TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "存储";
            // 
            // read
            // 
            this.read.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.read.Location = new System.Drawing.Point(241, 37);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(89, 51);
            this.read.TabIndex = 8;
            this.read.Text = "读(&R)";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // wirte
            // 
            this.wirte.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wirte.Location = new System.Drawing.Point(364, 37);
            this.wirte.Name = "wirte";
            this.wirte.Size = new System.Drawing.Size(89, 51);
            this.wirte.TabIndex = 8;
            this.wirte.Text = "写(&W)";
            this.wirte.UseVisualStyleBackColor = true;
            this.wirte.Click += new System.EventHandler(this.wirte_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "个数";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "地址";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtPort);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button DisconnectBtn;
        internal System.Windows.Forms.Button ConnectBtn;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtPort;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox bitValue;
        private System.Windows.Forms.TextBox write_value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button address_reduce;
        private System.Windows.Forms.Button address_add;
        private System.Windows.Forms.ComboBox address_type;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox address_;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button wirte;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox return_value;
    }
}

