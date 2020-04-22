using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FX_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FX_com = new FX();
        }

        private int address;

        private FX FX_com = null;

        private void connectPLC_Click(object sender, EventArgs e)
        {
            if (FX_com.serialPort1.IsOpen)
            {
                if (FX_com.Disconnect())
                { this.connectPLC.Text = "连接"; }
            }
            else
            {
                if (FX_com.connect(this.comportName.Text))
                { this.connectPLC.Text = "断开"; }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //自动获取COM口名称
            foreach (string com in System.IO.Ports.SerialPort.GetPortNames())
            {
                this.comportName.Items.Add(com);
            }
            address = 0;
            address_.Text = Convert.ToString(address);
            count.Text = "1";//默认个数
        }

        private void address_add_Click(object sender, EventArgs e)
        {
            address++;
            address_.Text = Convert.ToString(address);
        }

        private void address_reduce_Click(object sender, EventArgs e)
        {
            address--;
            address_.Text = Convert.ToString(address);
        }

        private void address__TextChanged(object sender, EventArgs e)
        {
            try
            {
                address = Int32.Parse(address_.Text);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void read_Click(object sender, EventArgs e)
        {
            return_value.Text = "";
            try
            {
                lock (this)
                {
                    byte[] data = null;
                    switch (address_type.Text)
                    {
                        case "D":
                            data = FX_com.read(FX.Typ.D, address, int.Parse(count.Text));
                            return_value.Text = data2string(data);
                            break;
                        case "M":
                            data = FX_com.read(FX.Typ.M, address, int.Parse(count.Text));
                            return_value.Text = data2string(data);
                            break;
                        case "X":
                            data = FX_com.read(FX.Typ.X, address, int.Parse(count.Text));
                            return_value.Text = data2string(data);
                            break;
                        case "Y":
                            data = FX_com.read(FX.Typ.Y, address, int.Parse(count.Text));
                            return_value.Text = data2string(data);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            System.Threading.Thread.Sleep(200);
        }

        public string data2string(byte[] data)
        {
            string return_string = "";
            for (int i = 0; i < data.Length; i += 4)
            {
                return_string += Encoding.ASCII.GetString(data, i + 2, 2);
                return_string += Encoding.ASCII.GetString(data, i, 2);
                if (i < data.Length - 4)
                {
                    return_string += " ";
                }
            }
            return return_string;
        }

        private void wirte_Click(object sender, EventArgs e)
        {
            try
            {
                lock (this)
                {
                    byte[] data = null;
                    switch (address_type.Text)
                    {
                        case "D":
                            bool write_ok = FX_com.write(FX.Typ.D, address, int.Parse(write_value.Text));
                            return_value.Text = write_ok.ToString();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
