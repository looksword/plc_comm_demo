﻿namespace Modbus_test
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.station_rtu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Parity_rtu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.baudRate_rtu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comportName_rtu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectPLC_RTU = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.connectPLC_TCP = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Parity_ascii = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.baudRate_ascii = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comportName_ascii = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.connectPLC_ASCII = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.area_rtu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.address_rtu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.length_rtu = new System.Windows.Forms.TextBox();
            this.read_rtu = new System.Windows.Forms.Button();
            this.write_rtu = new System.Windows.Forms.Button();
            this.value_rtu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.send_rtu = new System.Windows.Forms.TextBox();
            this.recv_rtu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.data_rtu = new System.Windows.Forms.TextBox();
            this.txt_rtu = new System.Windows.Forms.TextBox();
            this.txt_tcp = new System.Windows.Forms.TextBox();
            this.txt_ascii = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1114, 500);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_rtu);
            this.tabPage1.Controls.Add(this.data_rtu);
            this.tabPage1.Controls.Add(this.recv_rtu);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.send_rtu);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.value_rtu);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.write_rtu);
            this.tabPage1.Controls.Add(this.read_rtu);
            this.tabPage1.Controls.Add(this.length_rtu);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.address_rtu);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.area_rtu);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.station_rtu);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1106, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modbus Rtu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Parity_rtu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.baudRate_rtu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comportName_rtu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.connectPLC_RTU);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 72);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC通信";
            // 
            // station_rtu
            // 
            this.station_rtu.Location = new System.Drawing.Point(71, 93);
            this.station_rtu.Name = "station_rtu";
            this.station_rtu.Size = new System.Drawing.Size(90, 21);
            this.station_rtu.TabIndex = 44;
            this.station_rtu.Text = "1";
            this.station_rtu.TextChanged += new System.EventHandler(this.station_rtu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "站号：";
            // 
            // Parity_rtu
            // 
            this.Parity_rtu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Parity_rtu.FormattingEnabled = true;
            this.Parity_rtu.Items.AddRange(new object[] {
            "Even",
            "None",
            "Odd"});
            this.Parity_rtu.Location = new System.Drawing.Point(437, 25);
            this.Parity_rtu.Name = "Parity_rtu";
            this.Parity_rtu.Size = new System.Drawing.Size(90, 29);
            this.Parity_rtu.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(372, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "校验：";
            // 
            // baudRate_rtu
            // 
            this.baudRate_rtu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRate_rtu.FormattingEnabled = true;
            this.baudRate_rtu.Items.AddRange(new object[] {
            "9600",
            "19200"});
            this.baudRate_rtu.Location = new System.Drawing.Point(273, 25);
            this.baudRate_rtu.Name = "baudRate_rtu";
            this.baudRate_rtu.Size = new System.Drawing.Size(90, 29);
            this.baudRate_rtu.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(197, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "波特率：";
            // 
            // comportName_rtu
            // 
            this.comportName_rtu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comportName_rtu.FormattingEnabled = true;
            this.comportName_rtu.Location = new System.Drawing.Point(96, 25);
            this.comportName_rtu.Name = "comportName_rtu";
            this.comportName_rtu.Size = new System.Drawing.Size(90, 29);
            this.comportName_rtu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "端口号：";
            // 
            // connectPLC_RTU
            // 
            this.connectPLC_RTU.Location = new System.Drawing.Point(563, 23);
            this.connectPLC_RTU.Name = "connectPLC_RTU";
            this.connectPLC_RTU.Size = new System.Drawing.Size(155, 30);
            this.connectPLC_RTU.TabIndex = 0;
            this.connectPLC_RTU.Text = "连接";
            this.connectPLC_RTU.UseVisualStyleBackColor = true;
            this.connectPLC_RTU.Click += new System.EventHandler(this.connectPLC_com_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_tcp);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1106, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modbus Tcp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtPort);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtIP);
            this.groupBox2.Controls.Add(this.connectPLC_TCP);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1094, 72);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PLC通信";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Port";
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(314, 28);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(53, 29);
            this.TxtPort.TabIndex = 43;
            this.TxtPort.Text = "1099";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "IP Address";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(121, 28);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(139, 29);
            this.TxtIP.TabIndex = 42;
            this.TxtIP.Text = "192.168.1.188";
            // 
            // connectPLC_TCP
            // 
            this.connectPLC_TCP.Location = new System.Drawing.Point(384, 26);
            this.connectPLC_TCP.Name = "connectPLC_TCP";
            this.connectPLC_TCP.Size = new System.Drawing.Size(155, 30);
            this.connectPLC_TCP.TabIndex = 0;
            this.connectPLC_TCP.Text = "连接";
            this.connectPLC_TCP.UseVisualStyleBackColor = true;
            this.connectPLC_TCP.Click += new System.EventHandler(this.connectPLC_net_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txt_ascii);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1106, 474);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modbus Ascii";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Parity_ascii);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.baudRate_ascii);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.comportName_ascii);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.connectPLC_ASCII);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(6, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1094, 72);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PLC通信";
            // 
            // Parity_ascii
            // 
            this.Parity_ascii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Parity_ascii.FormattingEnabled = true;
            this.Parity_ascii.Items.AddRange(new object[] {
            "Even",
            "None",
            "Odd"});
            this.Parity_ascii.Location = new System.Drawing.Point(437, 25);
            this.Parity_ascii.Name = "Parity_ascii";
            this.Parity_ascii.Size = new System.Drawing.Size(90, 29);
            this.Parity_ascii.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(372, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "校验：";
            // 
            // baudRate_ascii
            // 
            this.baudRate_ascii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRate_ascii.FormattingEnabled = true;
            this.baudRate_ascii.Items.AddRange(new object[] {
            "9600",
            "19200"});
            this.baudRate_ascii.Location = new System.Drawing.Point(273, 25);
            this.baudRate_ascii.Name = "baudRate_ascii";
            this.baudRate_ascii.Size = new System.Drawing.Size(90, 29);
            this.baudRate_ascii.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(197, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "波特率：";
            // 
            // comportName_ascii
            // 
            this.comportName_ascii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comportName_ascii.FormattingEnabled = true;
            this.comportName_ascii.Location = new System.Drawing.Point(96, 25);
            this.comportName_ascii.Name = "comportName_ascii";
            this.comportName_ascii.Size = new System.Drawing.Size(90, 29);
            this.comportName_ascii.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(20, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "端口号：";
            // 
            // connectPLC_ASCII
            // 
            this.connectPLC_ASCII.Location = new System.Drawing.Point(563, 23);
            this.connectPLC_ASCII.Name = "connectPLC_ASCII";
            this.connectPLC_ASCII.Size = new System.Drawing.Size(155, 30);
            this.connectPLC_ASCII.TabIndex = 0;
            this.connectPLC_ASCII.Text = "连接";
            this.connectPLC_ASCII.UseVisualStyleBackColor = true;
            this.connectPLC_ASCII.Click += new System.EventHandler(this.connectPLC_ASCII_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(166, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "区域：";
            // 
            // area_rtu
            // 
            this.area_rtu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.area_rtu.FormattingEnabled = true;
            this.area_rtu.Items.AddRange(new object[] {
            "coil",
            "input",
            "Register",
            "InputRegister"});
            this.area_rtu.Location = new System.Drawing.Point(225, 93);
            this.area_rtu.Name = "area_rtu";
            this.area_rtu.Size = new System.Drawing.Size(90, 20);
            this.area_rtu.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(321, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 47;
            this.label9.Text = "地址：";
            // 
            // address_rtu
            // 
            this.address_rtu.Location = new System.Drawing.Point(378, 92);
            this.address_rtu.Name = "address_rtu";
            this.address_rtu.Size = new System.Drawing.Size(90, 21);
            this.address_rtu.TabIndex = 48;
            this.address_rtu.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(474, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 25);
            this.label10.TabIndex = 49;
            this.label10.Text = "长度：";
            // 
            // length_rtu
            // 
            this.length_rtu.Location = new System.Drawing.Point(532, 93);
            this.length_rtu.Name = "length_rtu";
            this.length_rtu.Size = new System.Drawing.Size(90, 21);
            this.length_rtu.TabIndex = 50;
            this.length_rtu.Text = "1";
            // 
            // read_rtu
            // 
            this.read_rtu.Location = new System.Drawing.Point(820, 87);
            this.read_rtu.Name = "read_rtu";
            this.read_rtu.Size = new System.Drawing.Size(102, 30);
            this.read_rtu.TabIndex = 51;
            this.read_rtu.Text = "读取";
            this.read_rtu.UseVisualStyleBackColor = true;
            this.read_rtu.Click += new System.EventHandler(this.read_rtu_Click);
            // 
            // write_rtu
            // 
            this.write_rtu.Location = new System.Drawing.Point(946, 87);
            this.write_rtu.Name = "write_rtu";
            this.write_rtu.Size = new System.Drawing.Size(102, 30);
            this.write_rtu.TabIndex = 52;
            this.write_rtu.Text = "写入";
            this.write_rtu.UseVisualStyleBackColor = true;
            this.write_rtu.Click += new System.EventHandler(this.write_rtu_Click);
            // 
            // value_rtu
            // 
            this.value_rtu.Location = new System.Drawing.Point(696, 93);
            this.value_rtu.Name = "value_rtu";
            this.value_rtu.Size = new System.Drawing.Size(90, 21);
            this.value_rtu.TabIndex = 54;
            this.value_rtu.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(638, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 25);
            this.label13.TabIndex = 53;
            this.label13.Text = "数值：";
            // 
            // send_rtu
            // 
            this.send_rtu.Location = new System.Drawing.Point(71, 130);
            this.send_rtu.Name = "send_rtu";
            this.send_rtu.ReadOnly = true;
            this.send_rtu.Size = new System.Drawing.Size(977, 21);
            this.send_rtu.TabIndex = 55;
            // 
            // recv_rtu
            // 
            this.recv_rtu.Location = new System.Drawing.Point(71, 166);
            this.recv_rtu.Name = "recv_rtu";
            this.recv_rtu.ReadOnly = true;
            this.recv_rtu.Size = new System.Drawing.Size(977, 21);
            this.recv_rtu.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(14, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 25);
            this.label14.TabIndex = 57;
            this.label14.Text = "发送：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(14, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 25);
            this.label15.TabIndex = 58;
            this.label15.Text = "接收：";
            // 
            // data_rtu
            // 
            this.data_rtu.Location = new System.Drawing.Point(19, 204);
            this.data_rtu.Multiline = true;
            this.data_rtu.Name = "data_rtu";
            this.data_rtu.Size = new System.Drawing.Size(1029, 234);
            this.data_rtu.TabIndex = 59;
            // 
            // txt_rtu
            // 
            this.txt_rtu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_rtu.Location = new System.Drawing.Point(3, 450);
            this.txt_rtu.Name = "txt_rtu";
            this.txt_rtu.ReadOnly = true;
            this.txt_rtu.Size = new System.Drawing.Size(1100, 21);
            this.txt_rtu.TabIndex = 60;
            // 
            // txt_tcp
            // 
            this.txt_tcp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_tcp.Location = new System.Drawing.Point(3, 450);
            this.txt_tcp.Name = "txt_tcp";
            this.txt_tcp.ReadOnly = true;
            this.txt_tcp.Size = new System.Drawing.Size(1100, 21);
            this.txt_tcp.TabIndex = 61;
            // 
            // txt_ascii
            // 
            this.txt_ascii.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_ascii.Location = new System.Drawing.Point(0, 453);
            this.txt_ascii.Name = "txt_ascii";
            this.txt_ascii.ReadOnly = true;
            this.txt_ascii.Size = new System.Drawing.Size(1106, 21);
            this.txt_ascii.TabIndex = 61;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 513);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Modbus";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox TxtPort;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.Button connectPLC_TCP;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox Parity_rtu;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox baudRate_rtu;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox comportName_rtu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectPLC_RTU;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox Parity_ascii;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox baudRate_ascii;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox comportName_ascii;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button connectPLC_ASCII;
        internal System.Windows.Forms.TextBox station_rtu;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox area_rtu;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox address_rtu;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox length_rtu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button write_rtu;
        private System.Windows.Forms.Button read_rtu;
        internal System.Windows.Forms.TextBox value_rtu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox recv_rtu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox send_rtu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_rtu;
        private System.Windows.Forms.TextBox data_rtu;
        private System.Windows.Forms.TextBox txt_tcp;
        private System.Windows.Forms.TextBox txt_ascii;
    }
}

