﻿namespace FX_test
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.write_value = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.return_value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.address_reduce = new System.Windows.Forms.Button();
            this.address_add = new System.Windows.Forms.Button();
            this.address_type = new System.Windows.Forms.ComboBox();
            this.count = new System.Windows.Forms.TextBox();
            this.address_ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.read = new System.Windows.Forms.Button();
            this.wirte = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comportName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectPLC = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.write_value);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.return_value);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.address_reduce);
            this.groupBox2.Controls.Add(this.address_add);
            this.groupBox2.Controls.Add(this.address_type);
            this.groupBox2.Controls.Add(this.count);
            this.groupBox2.Controls.Add(this.address_);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.read);
            this.groupBox2.Controls.Add(this.wirte);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(51, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 275);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // write_value
            // 
            this.write_value.Location = new System.Drawing.Point(353, 126);
            this.write_value.Name = "write_value";
            this.write_value.Size = new System.Drawing.Size(126, 33);
            this.write_value.TabIndex = 17;
            this.write_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "数值";
            // 
            // return_value
            // 
            this.return_value.Location = new System.Drawing.Point(96, 178);
            this.return_value.Name = "return_value";
            this.return_value.Size = new System.Drawing.Size(466, 33);
            this.return_value.TabIndex = 15;
            this.return_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "返回";
            // 
            // address_reduce
            // 
            this.address_reduce.Location = new System.Drawing.Point(96, 84);
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
            this.address_add.Location = new System.Drawing.Point(202, 82);
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
            "M",
            "X",
            "Y"});
            this.address_type.Location = new System.Drawing.Point(96, 39);
            this.address_type.Name = "address_type";
            this.address_type.Size = new System.Drawing.Size(126, 33);
            this.address_type.TabIndex = 13;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(96, 126);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(126, 33);
            this.count.TabIndex = 6;
            this.count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // address_
            // 
            this.address_.Location = new System.Drawing.Point(122, 84);
            this.address_.Name = "address_";
            this.address_.Size = new System.Drawing.Size(74, 33);
            this.address_.TabIndex = 12;
            this.address_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.address_.TextChanged += new System.EventHandler(this.address__TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "存储";
            // 
            // read
            // 
            this.read.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.read.Location = new System.Drawing.Point(282, 39);
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
            this.wirte.Location = new System.Drawing.Point(405, 39);
            this.wirte.Name = "wirte";
            this.wirte.Size = new System.Drawing.Size(89, 51);
            this.wirte.TabIndex = 8;
            this.wirte.Text = "写(&W)";
            this.wirte.UseVisualStyleBackColor = true;
            this.wirte.Click += new System.EventHandler(this.wirte_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "个数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "地址";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comportName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.connectPLC);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(51, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PLC通信";
            // 
            // comportName
            // 
            this.comportName.FormattingEnabled = true;
            this.comportName.Location = new System.Drawing.Point(173, 27);
            this.comportName.Name = "comportName";
            this.comportName.Size = new System.Drawing.Size(90, 29);
            this.comportName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(59, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "端口号：";
            // 
            // connectPLC
            // 
            this.connectPLC.Location = new System.Drawing.Point(282, 25);
            this.connectPLC.Name = "connectPLC";
            this.connectPLC.Size = new System.Drawing.Size(86, 30);
            this.connectPLC.TabIndex = 0;
            this.connectPLC.Text = "连接";
            this.connectPLC.UseVisualStyleBackColor = true;
            this.connectPLC.Click += new System.EventHandler(this.connectPLC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox write_value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox return_value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button address_reduce;
        private System.Windows.Forms.Button address_add;
        private System.Windows.Forms.ComboBox address_type;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox address_;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button wirte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox comportName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectPLC;

    }
}
