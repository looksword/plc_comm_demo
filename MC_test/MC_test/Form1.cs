using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProtocolType.SelectedIndex = 0;
            area_plc.SelectedIndex = 0;
            connectPLC_TCP.Enabled = true;
            read_plc.Enabled = false;
            write_plc.Enabled = false;
        }

        private IMelsecMaster Melsec = null;

        private void connectPLC_TCP_Click(object sender, EventArgs e)
        {
            try
            {
                if (Melsec == null)
                {
                    switch (ProtocolType.Text)
                    {
                        case "ASCII":
                            QsLsFXsAscTcp at = new QsLsFXsAscTcp();
                            at.ActHostAddress = TxtIP.Text;
                            at.ActPortNumber = int.Parse(TxtPort.Text);
                            at.Open();
                            Melsec = at;
                            break;
                        case "BINARY":
                            QsLsFXsBinTcp bt = new QsLsFXsBinTcp();
                            bt.ActHostAddress = TxtIP.Text;
                            bt.ActPortNumber = int.Parse(TxtPort.Text);
                            bt.Open();//
                            Melsec = bt;
                            break;
                    }
                    connectPLC_TCP.Text = "断开";
                    connectPLC_TCP.Enabled = false;
                    read_plc.Enabled = true;
                    write_plc.Enabled = true;
                }
                else
                {
                    Melsec = null;
                    connectPLC_TCP.Text = "连接";
                    connectPLC_TCP.Enabled = true;
                    read_plc.Enabled = false;
                    write_plc.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                txt_plc.Text = "连接错误 ： " + ex.Message;
                connectPLC_TCP.Enabled = true;
                read_plc.Enabled = false;
                write_plc.Enabled = false;
            }
        }

        private byte ShortToByte(short s)
        {
            return (byte)s;
        }

        private void read_plc_Click(object sender, EventArgs e)
        {
            try
            {
                if (Melsec != null)
                {
                    short[] data = null;
                    Melsec.ReadDeviceBlock(area_plc.Text, int.Parse(address_plc.Text), int.Parse(length_plc.Text), out data);
                    byte[] bytedata = Array.ConvertAll(data, new Converter<short, byte>(ShortToByte));
                    data_plc.Text = BitConverter.ToString(bytedata).Replace("-", " "); ;
                }
                else
                {
                    throw new Exception("Melsec不存在");
                }
            }
            catch(Exception ex)
            {
                txt_plc.Text = "读取错误 ： " + ex.Message;
            }
        }

        private void write_plc_Click(object sender, EventArgs e)
        {
            try
            {
                if (Melsec != null)
                {
                    short[] data = new short[1];
                    data[0] = short.Parse(value_plc.Text);
                    int value = 1;
                    value = Melsec.WriteDeviceBlock(area_plc.Text, int.Parse(address_plc.Text), data.Length, data);
                    if (value != 0)
                    {
                        throw new Exception("area:" + area_plc.Text + " address:" + address_plc.Text + " value:" + value_plc.Text);
                    }
                }
                else
                {
                    throw new Exception("Melsec不存在");
                }
            }
            catch (Exception ex)
            {
                txt_plc.Text = "写入错误 ： " + ex.Message;
            }
        }
    }
}
