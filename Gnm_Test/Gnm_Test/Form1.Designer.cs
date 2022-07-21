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
            this.text_num = new System.Windows.Forms.TextBox();
            this.text_addr = new System.Windows.Forms.TextBox();
            this.text_err = new System.Windows.Forms.TextBox();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.text_port = new System.Windows.Forms.TextBox();
            this.text_ip = new System.Windows.Forms.TextBox();
            this.text_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ReadFBtn
            // 
            this.ReadFBtn.Location = new System.Drawing.Point(293, 55);
            this.ReadFBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReadFBtn.Name = "ReadFBtn";
            this.ReadFBtn.Size = new System.Drawing.Size(127, 25);
            this.ReadFBtn.TabIndex = 20;
            this.ReadFBtn.Text = "读取(单个浮点数)";
            this.ReadFBtn.UseVisualStyleBackColor = true;
            this.ReadFBtn.Click += new System.EventHandler(this.ReadFBtn_Click);
            // 
            // text_data
            // 
            this.text_data.Location = new System.Drawing.Point(9, 90);
            this.text_data.Margin = new System.Windows.Forms.Padding(2);
            this.text_data.Multiline = true;
            this.text_data.Name = "text_data";
            this.text_data.ReadOnly = true;
            this.text_data.Size = new System.Drawing.Size(610, 95);
            this.text_data.TabIndex = 19;
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(217, 55);
            this.ReadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(61, 25);
            this.ReadBtn.TabIndex = 18;
            this.ReadBtn.Text = "读取(字)";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // text_num
            // 
            this.text_num.Location = new System.Drawing.Point(139, 59);
            this.text_num.Margin = new System.Windows.Forms.Padding(2);
            this.text_num.Name = "text_num";
            this.text_num.Size = new System.Drawing.Size(68, 21);
            this.text_num.TabIndex = 17;
            this.text_num.Text = "1";
            // 
            // text_addr
            // 
            this.text_addr.Location = new System.Drawing.Point(60, 59);
            this.text_addr.Margin = new System.Windows.Forms.Padding(2);
            this.text_addr.Name = "text_addr";
            this.text_addr.Size = new System.Drawing.Size(75, 21);
            this.text_addr.TabIndex = 16;
            this.text_addr.Text = "0";
            // 
            // text_err
            // 
            this.text_err.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.text_err.Location = new System.Drawing.Point(0, 192);
            this.text_err.Margin = new System.Windows.Forms.Padding(2);
            this.text_err.Name = "text_err";
            this.text_err.ReadOnly = true;
            this.text_err.Size = new System.Drawing.Size(627, 21);
            this.text_err.TabIndex = 15;
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Location = new System.Drawing.Point(241, 5);
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
            this.ConnectBtn.Location = new System.Drawing.Point(177, 5);
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
            this.text_type.FormattingEnabled = true;
            this.text_type.Items.AddRange(new object[] {
            "D",
            "M",
            "X",
            "Y"});
            this.text_type.Location = new System.Drawing.Point(9, 60);
            this.text_type.Name = "text_type";
            this.text_type.Size = new System.Drawing.Size(46, 20);
            this.text_type.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 213);
            this.Controls.Add(this.text_type);
            this.Controls.Add(this.ReadFBtn);
            this.Controls.Add(this.text_data);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.text_num);
            this.Controls.Add(this.text_addr);
            this.Controls.Add(this.text_err);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.text_port);
            this.Controls.Add(this.text_ip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadFBtn;
        private System.Windows.Forms.TextBox text_data;
        private System.Windows.Forms.Button ReadBtn;
        private System.Windows.Forms.TextBox text_num;
        private System.Windows.Forms.TextBox text_addr;
        private System.Windows.Forms.TextBox text_err;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.TextBox text_port;
        private System.Windows.Forms.TextBox text_ip;
        private System.Windows.Forms.ComboBox text_type;
    }
}

