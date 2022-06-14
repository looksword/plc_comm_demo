namespace S7_IO
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
            this.components = new System.ComponentModel.Container();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtSlot = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtRack = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.TextError = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TxtDB1 = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TxtSize1 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.CBArea1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CBWLen1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Offset1 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.ReadAble1 = new System.Windows.Forms.CheckBox();
            this.TxtDB2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSize2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CBArea2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CBWLen2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Offset2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReadAble2 = new System.Windows.Forms.CheckBox();
            this.TxtDB3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtSize3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CBArea3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CBWLen3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Offset3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ReadAble3 = new System.Windows.Forms.CheckBox();
            this.TxtDB4 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtSize4 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CBArea4 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.CBWLen4 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Offset4 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ReadAble4 = new System.Windows.Forms.CheckBox();
            this.TxtDB5 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.TxtSize5 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.CBArea5 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.CBWLen5 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Offset5 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ReadAble5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ReadBtn
            // 
            this.ReadBtn.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReadBtn.Location = new System.Drawing.Point(358, 10);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(171, 45);
            this.ReadBtn.TabIndex = 100;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Enabled = false;
            this.DisconnectBtn.Location = new System.Drawing.Point(236, 34);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(100, 21);
            this.DisconnectBtn.TabIndex = 95;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(236, 10);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(100, 21);
            this.ConnectBtn.TabIndex = 92;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(176, 7);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(29, 12);
            this.Label3.TabIndex = 94;
            this.Label3.Text = "Slot";
            // 
            // TxtSlot
            // 
            this.TxtSlot.Location = new System.Drawing.Point(176, 24);
            this.TxtSlot.Name = "TxtSlot";
            this.TxtSlot.Size = new System.Drawing.Size(44, 21);
            this.TxtSlot.TabIndex = 91;
            this.TxtSlot.Text = "0";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(119, 7);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(29, 12);
            this.Label2.TabIndex = 93;
            this.Label2.Text = "Rack";
            // 
            // TxtRack
            // 
            this.TxtRack.Location = new System.Drawing.Point(119, 24);
            this.TxtRack.Name = "TxtRack";
            this.TxtRack.Size = new System.Drawing.Size(44, 21);
            this.TxtRack.TabIndex = 89;
            this.TxtRack.Text = "0";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 12);
            this.Label1.TabIndex = 90;
            this.Label1.Text = "IP Address";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(10, 24);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(100, 21);
            this.TxtIP.TabIndex = 88;
            this.TxtIP.Text = "192.168.0.1";
            // 
            // TextError
            // 
            this.TextError.BackColor = System.Drawing.Color.White;
            this.TextError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextError.ForeColor = System.Drawing.Color.Black;
            this.TextError.Location = new System.Drawing.Point(0, 316);
            this.TextError.Name = "TextError";
            this.TextError.ReadOnly = true;
            this.TextError.Size = new System.Drawing.Size(546, 21);
            this.TextError.TabIndex = 152;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TxtDB1
            // 
            this.TxtDB1.Location = new System.Drawing.Point(359, 87);
            this.TxtDB1.Name = "TxtDB1";
            this.TxtDB1.Size = new System.Drawing.Size(45, 21);
            this.TxtDB1.TabIndex = 96;
            this.TxtDB1.Text = "1";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(356, 69);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(17, 12);
            this.Label6.TabIndex = 98;
            this.Label6.Text = "DB";
            // 
            // TxtSize1
            // 
            this.TxtSize1.Location = new System.Drawing.Point(410, 87);
            this.TxtSize1.Name = "TxtSize1";
            this.TxtSize1.Size = new System.Drawing.Size(57, 21);
            this.TxtSize1.TabIndex = 97;
            this.TxtSize1.Text = "1";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(407, 69);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(35, 12);
            this.Label7.TabIndex = 99;
            this.Label7.Text = "Bytes";
            // 
            // CBArea1
            // 
            this.CBArea1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBArea1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBArea1.FormattingEnabled = true;
            this.CBArea1.Items.AddRange(new object[] {
            "S7AreaPE  0x81",
            "S7AreaPA  0x82",
            "S7AreaMK  0x83",
            "S7AreaDB  0x84"});
            this.CBArea1.Location = new System.Drawing.Point(74, 86);
            this.CBArea1.Name = "CBArea1";
            this.CBArea1.Size = new System.Drawing.Size(132, 22);
            this.CBArea1.TabIndex = 101;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(72, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 102;
            this.label15.Text = "Area";
            // 
            // CBWLen1
            // 
            this.CBWLen1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBWLen1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBWLen1.FormattingEnabled = true;
            this.CBWLen1.Items.AddRange(new object[] {
            "S7WLBit      0x01",
            "S7WLByte     0x02",
            "S7WLChar     0x03",
            "S7WLWord     0x04",
            "S7WLInt      0x05",
            "S7WLDWord    0x06",
            "S7WLDInt     0x07",
            "S7WLReal     0x08"});
            this.CBWLen1.Location = new System.Drawing.Point(212, 86);
            this.CBWLen1.Name = "CBWLen1";
            this.CBWLen1.Size = new System.Drawing.Size(142, 22);
            this.CBWLen1.TabIndex = 103;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(209, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 104;
            this.label17.Text = "WordLength";
            // 
            // Offset1
            // 
            this.Offset1.Location = new System.Drawing.Point(473, 87);
            this.Offset1.Name = "Offset1";
            this.Offset1.Size = new System.Drawing.Size(57, 21);
            this.Offset1.TabIndex = 105;
            this.Offset1.Text = "0";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(471, 69);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(41, 12);
            this.label38.TabIndex = 106;
            this.label38.Text = "Offset";
            // 
            // ReadAble1
            // 
            this.ReadAble1.AutoSize = true;
            this.ReadAble1.Location = new System.Drawing.Point(12, 89);
            this.ReadAble1.Margin = new System.Windows.Forms.Padding(2);
            this.ReadAble1.Name = "ReadAble1";
            this.ReadAble1.Size = new System.Drawing.Size(48, 16);
            this.ReadAble1.TabIndex = 107;
            this.ReadAble1.Text = "采集";
            this.ReadAble1.UseVisualStyleBackColor = true;
            // 
            // TxtDB2
            // 
            this.TxtDB2.Location = new System.Drawing.Point(359, 135);
            this.TxtDB2.Name = "TxtDB2";
            this.TxtDB2.Size = new System.Drawing.Size(45, 21);
            this.TxtDB2.TabIndex = 108;
            this.TxtDB2.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 110;
            this.label10.Text = "DB";
            // 
            // TxtSize2
            // 
            this.TxtSize2.Location = new System.Drawing.Point(410, 135);
            this.TxtSize2.Name = "TxtSize2";
            this.TxtSize2.Size = new System.Drawing.Size(57, 21);
            this.TxtSize2.TabIndex = 109;
            this.TxtSize2.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 111;
            this.label9.Text = "Bytes";
            // 
            // CBArea2
            // 
            this.CBArea2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBArea2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBArea2.FormattingEnabled = true;
            this.CBArea2.Items.AddRange(new object[] {
            "S7AreaPE  0x81",
            "S7AreaPA  0x82",
            "S7AreaMK  0x83",
            "S7AreaDB  0x84"});
            this.CBArea2.Location = new System.Drawing.Point(74, 134);
            this.CBArea2.Name = "CBArea2";
            this.CBArea2.Size = new System.Drawing.Size(132, 22);
            this.CBArea2.TabIndex = 112;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 113;
            this.label8.Text = "Area";
            // 
            // CBWLen2
            // 
            this.CBWLen2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBWLen2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBWLen2.FormattingEnabled = true;
            this.CBWLen2.Items.AddRange(new object[] {
            "S7WLBit      0x01",
            "S7WLByte     0x02",
            "S7WLChar     0x03",
            "S7WLWord     0x04",
            "S7WLInt      0x05",
            "S7WLDWord    0x06",
            "S7WLDInt     0x07",
            "S7WLReal     0x08"});
            this.CBWLen2.Location = new System.Drawing.Point(212, 134);
            this.CBWLen2.Name = "CBWLen2";
            this.CBWLen2.Size = new System.Drawing.Size(142, 22);
            this.CBWLen2.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 115;
            this.label5.Text = "WordLength";
            // 
            // Offset2
            // 
            this.Offset2.Location = new System.Drawing.Point(473, 135);
            this.Offset2.Name = "Offset2";
            this.Offset2.Size = new System.Drawing.Size(57, 21);
            this.Offset2.TabIndex = 116;
            this.Offset2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 117;
            this.label4.Text = "Offset";
            // 
            // ReadAble2
            // 
            this.ReadAble2.AutoSize = true;
            this.ReadAble2.Location = new System.Drawing.Point(12, 137);
            this.ReadAble2.Margin = new System.Windows.Forms.Padding(2);
            this.ReadAble2.Name = "ReadAble2";
            this.ReadAble2.Size = new System.Drawing.Size(48, 16);
            this.ReadAble2.TabIndex = 118;
            this.ReadAble2.Text = "采集";
            this.ReadAble2.UseVisualStyleBackColor = true;
            // 
            // TxtDB3
            // 
            this.TxtDB3.Location = new System.Drawing.Point(359, 183);
            this.TxtDB3.Name = "TxtDB3";
            this.TxtDB3.Size = new System.Drawing.Size(45, 21);
            this.TxtDB3.TabIndex = 119;
            this.TxtDB3.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(356, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 121;
            this.label16.Text = "DB";
            // 
            // TxtSize3
            // 
            this.TxtSize3.Location = new System.Drawing.Point(410, 183);
            this.TxtSize3.Name = "TxtSize3";
            this.TxtSize3.Size = new System.Drawing.Size(57, 21);
            this.TxtSize3.TabIndex = 120;
            this.TxtSize3.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(407, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 122;
            this.label14.Text = "Bytes";
            // 
            // CBArea3
            // 
            this.CBArea3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBArea3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBArea3.FormattingEnabled = true;
            this.CBArea3.Items.AddRange(new object[] {
            "S7AreaPE  0x81",
            "S7AreaPA  0x82",
            "S7AreaMK  0x83",
            "S7AreaDB  0x84"});
            this.CBArea3.Location = new System.Drawing.Point(74, 182);
            this.CBArea3.Name = "CBArea3";
            this.CBArea3.Size = new System.Drawing.Size(132, 22);
            this.CBArea3.TabIndex = 123;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(72, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 124;
            this.label13.Text = "Area";
            // 
            // CBWLen3
            // 
            this.CBWLen3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBWLen3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBWLen3.FormattingEnabled = true;
            this.CBWLen3.Items.AddRange(new object[] {
            "S7WLBit      0x01",
            "S7WLByte     0x02",
            "S7WLChar     0x03",
            "S7WLWord     0x04",
            "S7WLInt      0x05",
            "S7WLDWord    0x06",
            "S7WLDInt     0x07",
            "S7WLReal     0x08"});
            this.CBWLen3.Location = new System.Drawing.Point(212, 182);
            this.CBWLen3.Name = "CBWLen3";
            this.CBWLen3.Size = new System.Drawing.Size(142, 22);
            this.CBWLen3.TabIndex = 125;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 126;
            this.label12.Text = "WordLength";
            // 
            // Offset3
            // 
            this.Offset3.Location = new System.Drawing.Point(473, 183);
            this.Offset3.Name = "Offset3";
            this.Offset3.Size = new System.Drawing.Size(57, 21);
            this.Offset3.TabIndex = 127;
            this.Offset3.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(471, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 128;
            this.label11.Text = "Offset";
            // 
            // ReadAble3
            // 
            this.ReadAble3.AutoSize = true;
            this.ReadAble3.Location = new System.Drawing.Point(12, 185);
            this.ReadAble3.Margin = new System.Windows.Forms.Padding(2);
            this.ReadAble3.Name = "ReadAble3";
            this.ReadAble3.Size = new System.Drawing.Size(48, 16);
            this.ReadAble3.TabIndex = 129;
            this.ReadAble3.Text = "采集";
            this.ReadAble3.UseVisualStyleBackColor = true;
            // 
            // TxtDB4
            // 
            this.TxtDB4.Location = new System.Drawing.Point(359, 231);
            this.TxtDB4.Name = "TxtDB4";
            this.TxtDB4.Size = new System.Drawing.Size(45, 21);
            this.TxtDB4.TabIndex = 130;
            this.TxtDB4.Text = "1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(356, 213);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 12);
            this.label22.TabIndex = 132;
            this.label22.Text = "DB";
            // 
            // TxtSize4
            // 
            this.TxtSize4.Location = new System.Drawing.Point(410, 231);
            this.TxtSize4.Name = "TxtSize4";
            this.TxtSize4.Size = new System.Drawing.Size(57, 21);
            this.TxtSize4.TabIndex = 131;
            this.TxtSize4.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(407, 213);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 12);
            this.label21.TabIndex = 133;
            this.label21.Text = "Bytes";
            // 
            // CBArea4
            // 
            this.CBArea4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBArea4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBArea4.FormattingEnabled = true;
            this.CBArea4.Items.AddRange(new object[] {
            "S7AreaPE  0x81",
            "S7AreaPA  0x82",
            "S7AreaMK  0x83",
            "S7AreaDB  0x84"});
            this.CBArea4.Location = new System.Drawing.Point(74, 230);
            this.CBArea4.Name = "CBArea4";
            this.CBArea4.Size = new System.Drawing.Size(132, 22);
            this.CBArea4.TabIndex = 134;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(72, 213);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 135;
            this.label20.Text = "Area";
            // 
            // CBWLen4
            // 
            this.CBWLen4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBWLen4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBWLen4.FormattingEnabled = true;
            this.CBWLen4.Items.AddRange(new object[] {
            "S7WLBit      0x01",
            "S7WLByte     0x02",
            "S7WLChar     0x03",
            "S7WLWord     0x04",
            "S7WLInt      0x05",
            "S7WLDWord    0x06",
            "S7WLDInt     0x07",
            "S7WLReal     0x08"});
            this.CBWLen4.Location = new System.Drawing.Point(212, 230);
            this.CBWLen4.Name = "CBWLen4";
            this.CBWLen4.Size = new System.Drawing.Size(142, 22);
            this.CBWLen4.TabIndex = 136;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(209, 213);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 137;
            this.label19.Text = "WordLength";
            // 
            // Offset4
            // 
            this.Offset4.Location = new System.Drawing.Point(473, 231);
            this.Offset4.Name = "Offset4";
            this.Offset4.Size = new System.Drawing.Size(57, 21);
            this.Offset4.TabIndex = 138;
            this.Offset4.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(471, 213);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 139;
            this.label18.Text = "Offset";
            // 
            // ReadAble4
            // 
            this.ReadAble4.AutoSize = true;
            this.ReadAble4.Location = new System.Drawing.Point(12, 233);
            this.ReadAble4.Margin = new System.Windows.Forms.Padding(2);
            this.ReadAble4.Name = "ReadAble4";
            this.ReadAble4.Size = new System.Drawing.Size(48, 16);
            this.ReadAble4.TabIndex = 140;
            this.ReadAble4.Text = "采集";
            this.ReadAble4.UseVisualStyleBackColor = true;
            // 
            // TxtDB5
            // 
            this.TxtDB5.Location = new System.Drawing.Point(359, 279);
            this.TxtDB5.Name = "TxtDB5";
            this.TxtDB5.Size = new System.Drawing.Size(45, 21);
            this.TxtDB5.TabIndex = 141;
            this.TxtDB5.Text = "1";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(356, 261);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(17, 12);
            this.label27.TabIndex = 143;
            this.label27.Text = "DB";
            // 
            // TxtSize5
            // 
            this.TxtSize5.Location = new System.Drawing.Point(410, 279);
            this.TxtSize5.Name = "TxtSize5";
            this.TxtSize5.Size = new System.Drawing.Size(57, 21);
            this.TxtSize5.TabIndex = 142;
            this.TxtSize5.Text = "1";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(407, 261);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 12);
            this.label26.TabIndex = 144;
            this.label26.Text = "Bytes";
            // 
            // CBArea5
            // 
            this.CBArea5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBArea5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBArea5.FormattingEnabled = true;
            this.CBArea5.Items.AddRange(new object[] {
            "S7AreaPE  0x81",
            "S7AreaPA  0x82",
            "S7AreaMK  0x83",
            "S7AreaDB  0x84"});
            this.CBArea5.Location = new System.Drawing.Point(74, 278);
            this.CBArea5.Name = "CBArea5";
            this.CBArea5.Size = new System.Drawing.Size(132, 22);
            this.CBArea5.TabIndex = 145;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(72, 261);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 146;
            this.label25.Text = "Area";
            // 
            // CBWLen5
            // 
            this.CBWLen5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBWLen5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBWLen5.FormattingEnabled = true;
            this.CBWLen5.Items.AddRange(new object[] {
            "S7WLBit      0x01",
            "S7WLByte     0x02",
            "S7WLChar     0x03",
            "S7WLWord     0x04",
            "S7WLInt      0x05",
            "S7WLDWord    0x06",
            "S7WLDInt     0x07",
            "S7WLReal     0x08"});
            this.CBWLen5.Location = new System.Drawing.Point(212, 278);
            this.CBWLen5.Name = "CBWLen5";
            this.CBWLen5.Size = new System.Drawing.Size(142, 22);
            this.CBWLen5.TabIndex = 147;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(209, 261);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 148;
            this.label24.Text = "WordLength";
            // 
            // Offset5
            // 
            this.Offset5.Location = new System.Drawing.Point(473, 279);
            this.Offset5.Name = "Offset5";
            this.Offset5.Size = new System.Drawing.Size(57, 21);
            this.Offset5.TabIndex = 149;
            this.Offset5.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(471, 261);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 12);
            this.label23.TabIndex = 150;
            this.label23.Text = "Offset";
            // 
            // ReadAble5
            // 
            this.ReadAble5.AutoSize = true;
            this.ReadAble5.Location = new System.Drawing.Point(12, 281);
            this.ReadAble5.Margin = new System.Windows.Forms.Padding(2);
            this.ReadAble5.Name = "ReadAble5";
            this.ReadAble5.Size = new System.Drawing.Size(48, 16);
            this.ReadAble5.TabIndex = 151;
            this.ReadAble5.Text = "采集";
            this.ReadAble5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 337);
            this.Controls.Add(this.TextError);
            this.Controls.Add(this.ReadAble5);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.Offset5);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.CBWLen5);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.CBArea5);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.TxtSize5);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.TxtDB5);
            this.Controls.Add(this.ReadAble4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Offset4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.CBWLen4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.CBArea4);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.TxtSize4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.TxtDB4);
            this.Controls.Add(this.ReadAble3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Offset3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CBWLen3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CBArea3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtSize3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtDB3);
            this.Controls.Add(this.ReadAble2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Offset2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBWLen2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CBArea2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtSize2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtDB2);
            this.Controls.Add(this.ReadAble1);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.Offset1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CBWLen1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CBArea1);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TxtSize1);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TxtDB1);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtSlot);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtRack);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button ReadBtn;
        internal System.Windows.Forms.Button DisconnectBtn;
        internal System.Windows.Forms.Button ConnectBtn;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtSlot;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtRack;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtIP;
        internal System.Windows.Forms.TextBox TextError;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.TextBox TxtDB1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TxtSize1;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.ComboBox CBArea1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CBWLen1;
        private System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox Offset1;
        internal System.Windows.Forms.Label label38;
        private System.Windows.Forms.CheckBox ReadAble1;
        internal System.Windows.Forms.TextBox TxtDB2;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox TxtSize2;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CBArea2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CBWLen2;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox Offset2;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ReadAble2;
        internal System.Windows.Forms.TextBox TxtDB3;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox TxtSize3;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CBArea3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CBWLen3;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox Offset3;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ReadAble3;
        internal System.Windows.Forms.TextBox TxtDB4;
        internal System.Windows.Forms.Label label22;
        internal System.Windows.Forms.TextBox TxtSize4;
        internal System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox CBArea4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox CBWLen4;
        private System.Windows.Forms.Label label19;
        internal System.Windows.Forms.TextBox Offset4;
        internal System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox ReadAble4;
        internal System.Windows.Forms.TextBox TxtDB5;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.TextBox TxtSize5;
        internal System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox CBArea5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox CBWLen5;
        private System.Windows.Forms.Label label24;
        internal System.Windows.Forms.TextBox Offset5;
        internal System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox ReadAble5;
    }
}

