using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gnm;
using Gnm.Device;
using Gnm.Utility;

namespace Gnm_Test
{
    public partial class Form1 : Form
    {
        private GnmMaster GNM = null;
        private bool connected = false;

        public Form1()
        {
            InitializeComponent();
            ReadBtn.Enabled = false;
            ReadbitBtn.Enabled = false;
            DisconnectBtn.Enabled = false;
            text_type.SelectedIndex = 0;
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(!connected)
                {
                    GNM = GnmSerialMaster.Create(new TcpClient(text_ip.Text, int.Parse(text_port.Text)));

                    if ((GNM != null) && (GNM.Transport != null))
                    {
                        ReadBtn.Enabled = true;
                        ReadbitBtn.Enabled = true;
                        DisconnectBtn.Enabled = true;
                        ConnectBtn.Enabled = false;
                        connected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                text_err.Text = ex.Message;
            }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (connected)
                {
                    if (GNM != null)
                    {
                        try { using (GNM) { } }
                        finally { GNM = null; }
                    }
                    ReadBtn.Enabled = false;
                    ReadbitBtn.Enabled = false;
                    DisconnectBtn.Enabled = false;
                    ConnectBtn.Enabled = true;
                    connected = false;
                }
            }
            catch (Exception ex)
            {
                text_err.Text = ex.Message;
            }
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Elapsed = Environment.TickCount;
                UInt32[] data = null;
                string addrtype = text_type.Text;
                ushort addrStart = ushort.Parse(text_addr.Text.Trim());
                ushort SizeRead = ushort.Parse(text_num.Text.Trim());
                StringBuilder outputstr = new StringBuilder();
                switch (addrtype)
                {
                    case "D":
                        {
                            ushort[] ddata = GNM.ReadHoldingRegisters(0x01, addrStart, SizeRead);
                            data = Array.ConvertAll(ddata, new Converter<ushort, UInt32>(UshortToUInt32));
                            break;
                        }
                    case "M":
                        {
                            bool[] bData = GNM.ReadCoils(0x01, addrStart, SizeRead);
                            data = Array.ConvertAll(bData, new Converter<bool, UInt32>(BoolToUInt32));
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                int Time_ms = Environment.TickCount - Elapsed;
                if (data != null)
                {
                    for (int i = 0; i < SizeRead; i++)
                    {
                        outputstr.Append(data[i].ToString());
                        outputstr.Append(" ");
                    }
                    text_data.Text = outputstr.ToString();

                    
                    text_err.Text = "(" + Time_ms.ToString() + " ms)";
                }
                else
                {
                    text_data.Clear();
                    text_err.Text = "Failed to read (" + Time_ms.ToString() + " ms)";
                }
            }
            catch (Exception ex)
            {
                text_data.Clear();
                text_err.Text = ex.Message;
                DisconnectBtn_Click(null, null);
            }
        }

        private void ReadbitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Elapsed = Environment.TickCount;
                UInt32[] data = null;
                string addrtype = text_type.Text;
                ushort addrStart = ushort.Parse(text_addr.Text.Trim());
                ushort SizeRead = ushort.Parse(text_num.Text.Trim());
                StringBuilder outputstr = new StringBuilder();
                switch (addrtype)
                {
                    case "M":
                        {
                            bool[] bData = GNM.ReadCoils(0x01, addrStart, SizeRead);
                            data = Array.ConvertAll(bData, new Converter<bool, UInt32>(BoolToUInt32));
                            break;
                        }
                    case "X":
                        {
                            bool[] bData = GNM.ReadXareas(0x01, addrStart, SizeRead);//ReadXarea
                            data = Array.ConvertAll(bData, new Converter<bool, UInt32>(BoolToUInt32));
                            break;
                        }
                    case "Y":
                        {
                            bool[] bData = GNM.ReadYareas(0x01, addrStart, SizeRead);//ReadYarea
                            data = Array.ConvertAll(bData, new Converter<bool, UInt32>(BoolToUInt32));
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                int Time_ms = Environment.TickCount - Elapsed;
                if (data != null)
                {
                    for (int i = 0; i < SizeRead; i++)
                    {
                        outputstr.Append(data[i].ToString());
                        outputstr.Append(" ");
                    }
                    text_data.Text = outputstr.ToString();


                    text_err.Text = "(" + Time_ms.ToString() + " ms)";
                }
                else
                {
                    text_data.Clear();
                    text_err.Text = "Failed to read (" + Time_ms.ToString() + " ms)";
                }
            }
            catch (Exception ex)
            {
                text_data.Clear();
                text_err.Text = ex.Message;
                DisconnectBtn_Click(null, null);
            }
        }

        private void ReadFBtn_Click(object sender, EventArgs e)
        {

        }

        private UInt32 BoolToUInt32(bool b)
        {
            return (UInt32)(b ? 1 : 0);
        }

        private UInt32 UshortToUInt32(ushort s)
        {
            return (UInt32)s;
        }
    }
}
