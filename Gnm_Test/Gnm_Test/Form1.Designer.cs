namespace Gnm_Test
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
            this.ReadFBtn = new System.Windows.Forms.Button();
            this.text_data = new System.Windows.Forms.TextBox();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.text_addr = new System.Windows.Forms.TextBox();
            this.text_err = new System.Windows.Forms.TextBox();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.text_port = new System.Windows.Forms.TextBox();
            this.text_ip = new System.Windows.Forms.TextBox();
            this.text_type = new System.Windows.Forms.ComboBox();
            this.ReadbitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_num = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.text_num)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadFBtn
            // 
            this.ReadFBtn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReadFBtn.Location = new System.Drawing.Point(354, 11);
            this.ReadFBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReadFBtn.Name = "ReadFBtn";
            this.ReadFBtn.Size = new System.Drawing.Size(173, 25);
            this.ReadFBtn.TabIndex = 20;
            this.ReadFBtn.Text = "读取(单个浮点数)";
            this.ReadFBtn.UseVisualStyleBackColor = true;
            this.ReadFBtn.Visible = false;
            this.ReadFBtn.Click += new System.EventHandler(this.ReadFBtn_Click);
            // 
            // text_data
            // 
            this.text_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_data.Location = new System.Drawing.Point(9, 103);
            this.text_data.Margin = new System.Windows.Forms.Padding(2);
            this.text_data.Multiline = true;
            this.text_data.Name = "text_data";
            this.text_data.ReadOnly = true;
            this.text_data.Size = new System.Drawing.Size(520, 97);
            this.text_data.TabIndex = 19;
            // 
            // ReadBtn
            // 
            this.ReadBtn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReadBtn.Location = new System.Drawing.Point(241, 56);
            this.ReadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(99, 33);
            this.ReadBtn.TabIndex = 18;
            this.ReadBtn.Text = "读取(字)";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // text_addr
            // 
            this.text_addr.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_addr.Location = new System.Drawing.Point(64, 59);
            this.text_addr.Margin = new System.Windows.Forms.Padding(2);
            this.text_addr.Name = "text_addr";
            this.text_addr.Size = new System.Drawing.Size(75, 29);
            this.text_addr.TabIndex = 16;
            this.text_addr.Text = "0";
            // 
            // text_err
            // 
            this.text_err.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_err.Location = new System.Drawing.Point(0, 207);
            this.text_err.Margin = new System.Windows.Forms.Padding(2);
            this.text_err.Name = "text_err";
            this.text_err.ReadOnly = true;
            this.text_err.Size = new System.Drawing.Size(538, 21);
            this.text_err.TabIndex = 15;
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(241, 2);
            this.DisconnectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(50, 27);
            this.DisconnectBtn.TabIndex = 14;
            this.DisconnectBtn.Text = "断开";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(177, 2);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(50, 27);
            this.ConnectBtn.TabIndex = 13;
            this.ConnectBtn.Text = "连接";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // text_port
            // 
            this.text_port.Location = new System.Drawing.Point(100, 4);
            this.text_port.Margin = new System.Windows.Forms.Padding(2);
            this.text_port.Name = "text_port";
            this.text_port.Size = new System.Drawing.Size(68, 21);
            this.text_port.TabIndex = 12;
            this.text_port.Text = "5549";
            // 
            // text_ip
            // 
            this.text_ip.Location = new System.Drawing.Point(9, 5);
            this.text_ip.Margin = new System.Windows.Forms.Padding(2);
            this.text_ip.Name = "text_ip";
            this.text_ip.Size = new System.Drawing.Size(88, 21);
            this.text_ip.TabIndex = 11;
            this.text_ip.Text = "192.168.1.15";
            // 
            // text_type
            // 
            this.text_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_type.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_type.FormattingEnabled = true;
            this.text_type.Items.AddRange(new object[] {
            "D",
            "M",
            "X",
            "Y"});
            this.text_type.Location = new System.Drawing.Point(9, 60);
            this.text_type.Name = "text_type";
            this.text_type.Size = new System.Drawing.Size(46, 27);
            this.text_type.TabIndex = 22;
            // 
            // ReadbitBtn
            // 
            this.ReadbitBtn.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReadbitBtn.Location = new System.Drawing.Point(354, 56);
            this.ReadbitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReadbitBtn.Name = "ReadbitBtn";
            this.ReadbitBtn.Size = new System.Drawing.Size(94, 33);
            this.ReadbitBtn.TabIndex = 23;
            this.ReadbitBtn.Text = "读取(位)";
            this.ReadbitBtn.UseVisualStyleBackColor = true;
            this.ReadbitBtn.Click += new System.EventHandler(this.ReadbitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "offset";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "length";
            // 
            // text_num
            // 
            this.text_num.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_num.Location = new System.Drawing.Point(149, 59);
            this.text_num.Name = "text_num";
            this.text_num.Size = new System.Drawing.Size(78, 29);
            this.text_num.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 228);
            this.Controls.Add(this.text_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadbitBtn);
            this.Controls.Add(this.text_type);
            this.Controls.Add(this.ReadFBtn);
            this.Controls.Add(this.text_data);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.text_addr);
            this.Controls.Add(this.text_err);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.text_port);
            this.Controls.Add(this.text_ip);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.text_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadFBtn;
        private System.Windows.Forms.TextBox text_data;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.TextBox text_addr;
        private System.Windows.Forms.TextBox text_err;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.TextBox text_port;
        private System.Windows.Forms.TextBox text_ip;
        private System.Windows.Forms.ComboBox text_type;
        private System.Windows.Forms.Button ReadbitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown text_num;
    }
}

