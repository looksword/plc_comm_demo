using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyence_test
{
    public partial class Form1 : Form
    {
        private UpperLink upLink_;

        public Form1()
        {
            InitializeComponent();
            connect.Enabled = true;
            disconnect.Enabled = false;
            readbit.Enabled = false;
            readDS.Enabled = false;
            readbitS.Enabled = false;
            writeB.Enabled = false;
            readD_area.SelectedIndex = 0;
            readDS_area.SelectedIndex = 0;
            readDS_type.SelectedIndex = 2;
            writeValue.SelectedIndex = 1;
        }

        private void HexDump(TextBox DumpBox, string[] data)
        {
            string all_data = "";
            int bytesLength = data.Length;
            int bytesPerLine; //每行填写几个数
            switch (readDS_type.Text)
            {
                case ".D":
                case ".L":
                    bytesPerLine = 8;
                    break;
                case ".H":
                    bytesPerLine = 16;
                    break;
                case ".U":
                case ".S":
                    bytesPerLine = 12;
                    break;
                default:
                    bytesPerLine = 12;
                    break;
            }
            for (int i = 0; i < bytesLength; i++)
            {
                all_data += data[i];
                if ((i + 1) % bytesPerLine != 0 && i < bytesLength - 1)
                {
                    all_data += "  ";
                }
                else if (i < bytesLength - 1)
                {
                    all_data += Environment.NewLine;
                }
            }
            DumpBox.Text = all_data;
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (upLink_ == null)
                {
                    upLink_ = new UpperLink();
                }
                upLink_.Conn(plc_ip.Text, int.Parse(plc_port.Text));
                if (upLink_.connected)
                {
                    connect.Enabled = false;
                    disconnect.Enabled = true;
                    readbit.Enabled = true;
                    readDS.Enabled = true;
                    readbitS.Enabled = true;
                    writeB.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                txt_plc.Text = "连接错误 ： " + ex.Message;
            }
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (upLink_ != null)
                {
                    try { upLink_.Disconn(); }
                    finally
                    {
                        upLink_ = null;
                        connect.Enabled = true;
                        disconnect.Enabled = false;
                        readbit.Enabled = false;
                        readDS.Enabled = false;
                        readbitS.Enabled = false;
                        writeB.Enabled = false;
                    }
                }
            }
            catch(Exception ex)
            {
                txt_plc.Text = "连接错误 ： " + ex.Message;
            }
        }

        private void readbit_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = upLink_.Readbit(readD_area.Text, int.Parse(readD_addr.Text));
                receive_data.Text = upLink_.receive_string;
            }
            catch(Exception ex)
            {
                txt_plc.Text = "读取单个位点错误 ： " + ex.Message;
            }
        }

        private void readDS_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = upLink_.ReadDS(readDS_area.Text, int.Parse(readDS_addr.Text), int.Parse(readDS_count.Text), readDS_type.Text);
                string[] stringdata = upLink_.receive_string.Split(' ');
                HexDump(receive_data, stringdata);
            }
            catch (Exception ex)
            {
                txt_plc.Text = "读取字错误 ： " + ex.Message;
            }
        }

        private void readbitS_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = upLink_.ReadbitS(readD_area.Text, int.Parse(readD_addr.Text), int.Parse(readDS_count.Text));
                receive_data.Text = upLink_.receive_string;
            }
            catch (Exception ex)
            {
                txt_plc.Text = "读取多个位点错误 ： " + ex.Message;
            }
        }

        private void writeB_Click(object sender, EventArgs e)
        {
            try
            {
                bool writeok = upLink_.WriteB(readD_area.Text, int.Parse(readD_addr.Text), bool.Parse(writeValue.Text));
                receive_data.Text = "写入 " + readD_area.Text + " " + readD_addr.Text + " " + writeok.ToString();
            }
            catch (Exception ex)
            {
                txt_plc.Text = "写入位点错误 ： " + ex.Message;
            }
        }
    }
}
