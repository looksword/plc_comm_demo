namespace Keyence_test
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.writeB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.readbitS = new System.Windows.Forms.Button();
            this.readDS_count = new System.Windows.Forms.TextBox();
            this.readDS = new System.Windows.Forms.Button();
            this.readbit = new System.Windows.Forms.Button();
            this.readDS_type = new System.Windows.Forms.ComboBox();
            this.readDS_addr = new System.Windows.Forms.TextBox();
            this.readD_addr = new System.Windows.Forms.TextBox();
            this.readDS_area = new System.Windows.Forms.ComboBox();
            this.readD_area = new System.Windows.Forms.ComboBox();
            this.disconnect = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.plc_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plc_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receive_data = new System.Windows.Forms.TextBox();
            this.txt_plc = new System.Windows.Forms.TextBox();
            this.writeValue = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.writeValue);
            this.groupBox1.Controls.Add(this.writeB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.readbitS);
            this.groupBox1.Controls.Add(this.readDS_count);
            this.groupBox1.Controls.Add(this.readDS);
            this.groupBox1.Controls.Add(this.readbit);
            this.groupBox1.Controls.Add(this.readDS_type);
            this.groupBox1.Controls.Add(this.readDS_addr);
            this.groupBox1.Controls.Add(this.readD_addr);
            this.groupBox1.Controls.Add(this.readDS_area);
            this.groupBox1.Controls.Add(this.readD_area);
            this.groupBox1.Controls.Add(this.disconnect);
            this.groupBox1.Controls.Add(this.connect);
            this.groupBox1.Controls.Add(this.plc_port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.plc_ip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC通讯";
            // 
            // writeB
            // 
            this.writeB.Location = new System.Drawing.Point(772, 32);
            this.writeB.Name = "writeB";
            this.writeB.Size = new System.Drawing.Size(81, 21);
            this.writeB.TabIndex = 44;
            this.writeB.Text = "writeB";
            this.writeB.UseVisualStyleBackColor = true;
            this.writeB.Click += new System.EventHandler(this.writeB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 42;
            this.label6.Text = "num";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 41;
            this.label5.Text = "type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 40;
            this.label4.Text = "address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 39;
            this.label3.Text = "area";
            // 
            // readbitS
            // 
            this.readbitS.Location = new System.Drawing.Point(654, 65);
            this.readbitS.Name = "readbitS";
            this.readbitS.Size = new System.Drawing.Size(81, 21);
            this.readbitS.TabIndex = 38;
            this.readbitS.Text = "readbitS";
            this.readbitS.UseVisualStyleBackColor = true;
            this.readbitS.Click += new System.EventHandler(this.readbitS_Click);
            // 
            // readDS_count
            // 
            this.readDS_count.Location = new System.Drawing.Point(478, 66);
            this.readDS_count.Name = "readDS_count";
            this.readDS_count.Size = new System.Drawing.Size(54, 21);
            this.readDS_count.TabIndex = 37;
            this.readDS_count.Text = "4";
            this.readDS_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // readDS
            // 
            this.readDS.Location = new System.Drawing.Point(556, 65);
            this.readDS.Name = "readDS";
            this.readDS.Size = new System.Drawing.Size(81, 21);
            this.readDS.TabIndex = 36;
            this.readDS.Text = "readDS";
            this.readDS.UseVisualStyleBackColor = true;
            this.readDS.Click += new System.EventHandler(this.readDS_Click);
            // 
            // readbit
            // 
            this.readbit.Location = new System.Drawing.Point(556, 32);
            this.readbit.Name = "readbit";
            this.readbit.Size = new System.Drawing.Size(81, 21);
            this.readbit.TabIndex = 35;
            this.readbit.Text = "readbit";
            this.readbit.UseVisualStyleBackColor = true;
            this.readbit.Click += new System.EventHandler(this.readbit_Click);
            // 
            // readDS_type
            // 
            this.readDS_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.readDS_type.FormattingEnabled = true;
            this.readDS_type.Items.AddRange(new object[] {
            ".U",
            ".S",
            ".D",
            ".L",
            ".H"});
            this.readDS_type.Location = new System.Drawing.Point(416, 67);
            this.readDS_type.Name = "readDS_type";
            this.readDS_type.Size = new System.Drawing.Size(49, 20);
            this.readDS_type.TabIndex = 34;
            // 
            // readDS_addr
            // 
            this.readDS_addr.Location = new System.Drawing.Point(349, 67);
            this.readDS_addr.Name = "readDS_addr";
            this.readDS_addr.Size = new System.Drawing.Size(54, 21);
            this.readDS_addr.TabIndex = 33;
            this.readDS_addr.Text = "0";
            this.readDS_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // readD_addr
            // 
            this.readD_addr.Location = new System.Drawing.Point(349, 33);
            this.readD_addr.Name = "readD_addr";
            this.readD_addr.Size = new System.Drawing.Size(54, 21);
            this.readD_addr.TabIndex = 32;
            this.readD_addr.Text = "0";
            this.readD_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // readDS_area
            // 
            this.readDS_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.readDS_area.FormattingEnabled = true;
            this.readDS_area.Items.AddRange(new object[] {
            "DM",
            "EM",
            "FM",
            "ZF",
            "W",
            "CM",
            "VM"});
            this.readDS_area.Location = new System.Drawing.Point(282, 67);
            this.readDS_area.Name = "readDS_area";
            this.readDS_area.Size = new System.Drawing.Size(49, 20);
            this.readDS_area.TabIndex = 31;
            // 
            // readD_area
            // 
            this.readD_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.readD_area.FormattingEnabled = true;
            this.readD_area.Items.AddRange(new object[] {
            "R",
            "B",
            "MR",
            "LR",
            "CR",
            "VB"});
            this.readD_area.Location = new System.Drawing.Point(282, 34);
            this.readD_area.Name = "readD_area";
            this.readD_area.Size = new System.Drawing.Size(49, 20);
            this.readD_area.TabIndex = 30;
            // 
            // disconnect
            // 
            this.disconnect.Location = new System.Drawing.Point(168, 66);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(81, 21);
            this.disconnect.TabIndex = 29;
            this.disconnect.Text = "disconnect";
            this.disconnect.UseVisualStyleBackColor = true;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(168, 33);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(81, 21);
            this.connect.TabIndex = 28;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // plc_port
            // 
            this.plc_port.Location = new System.Drawing.Point(57, 66);
            this.plc_port.Name = "plc_port";
            this.plc_port.ReadOnly = true;
            this.plc_port.Size = new System.Drawing.Size(97, 21);
            this.plc_port.TabIndex = 27;
            this.plc_port.Text = "8501";
            this.plc_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "port";
            // 
            // plc_ip
            // 
            this.plc_ip.Location = new System.Drawing.Point(57, 33);
            this.plc_ip.Name = "plc_ip";
            this.plc_ip.Size = new System.Drawing.Size(97, 21);
            this.plc_ip.TabIndex = 25;
            this.plc_ip.Text = "192.168.0.10";
            this.plc_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "ip";
            // 
            // receive_data
            // 
            this.receive_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receive_data.Dock = System.Windows.Forms.DockStyle.Top;
            this.receive_data.Location = new System.Drawing.Point(0, 109);
            this.receive_data.Multiline = true;
            this.receive_data.Name = "receive_data";
            this.receive_data.ReadOnly = true;
            this.receive_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.receive_data.Size = new System.Drawing.Size(876, 302);
            this.receive_data.TabIndex = 16;
            this.receive_data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.receive_data.WordWrap = false;
            // 
            // txt_plc
            // 
            this.txt_plc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_plc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_plc.Location = new System.Drawing.Point(0, 424);
            this.txt_plc.Name = "txt_plc";
            this.txt_plc.ReadOnly = true;
            this.txt_plc.Size = new System.Drawing.Size(876, 21);
            this.txt_plc.TabIndex = 61;
            // 
            // writeValue
            // 
            this.writeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.writeValue.FormattingEnabled = true;
            this.writeValue.Items.AddRange(new object[] {
            "true",
            "false"});
            this.writeValue.Location = new System.Drawing.Point(654, 34);
            this.writeValue.Name = "writeValue";
            this.writeValue.Size = new System.Drawing.Size(81, 20);
            this.writeValue.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 445);
            this.Controls.Add(this.txt_plc);
            this.Controls.Add(this.receive_data);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button writeB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button readbitS;
        private System.Windows.Forms.TextBox readDS_count;
        private System.Windows.Forms.Button readDS;
        private System.Windows.Forms.Button readbit;
        private System.Windows.Forms.ComboBox readDS_type;
        private System.Windows.Forms.TextBox readDS_addr;
        private System.Windows.Forms.TextBox readD_addr;
        private System.Windows.Forms.ComboBox readDS_area;
        private System.Windows.Forms.ComboBox readD_area;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox plc_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox plc_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox receive_data;
        private System.Windows.Forms.TextBox txt_plc;
        private System.Windows.Forms.ComboBox writeValue;
    }
}

