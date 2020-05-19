using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCNetS7200;

namespace BCNetS7200
{
    public partial class Form1 : Form
    {
        private BCNetS7200 Client;
        public Form1()
        {
            InitializeComponent();
            Client = new BCNetS7200();
            Area.SelectedIndex = 2;
            ConnectBtn.Enabled = true;
            DisconnectBtn.Enabled = false;
            ReadBtn.Enabled = false;
            WriteBtn.Enabled = false;
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Client.Connect(TxtIP.Text, int.Parse(TxtPort.Text));
                ConnectBtn.Enabled = false;
                DisconnectBtn.Enabled = true;
                ReadBtn.Enabled = true;
                WriteBtn.Enabled = true;
            }
            catch(Exception ex)
            {
                TxtTime.Text = "Connect error : " + ex.Message;
            }
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Client.Disconnect();
                ConnectBtn.Enabled = true;
                DisconnectBtn.Enabled = false;
                ReadBtn.Enabled = false;
                WriteBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                TxtTime.Text = "Disconnect error : " + ex.Message;
            }
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            int Elapsed = Environment.TickCount;
            try
            {
                byte[] data = null;
                switch (Area.Text)
                {
                    case "I":
                        data = Client.Read(BCNetS7200.Type.I, int.Parse(TxtAddr.Text), int.Parse(TxtLength.Text));
                        break;
                    case "Q":
                        data = Client.Read(BCNetS7200.Type.Q, int.Parse(TxtAddr.Text), int.Parse(TxtLength.Text));
                        break;
                    case "V":
                        data = Client.Read(BCNetS7200.Type.V, int.Parse(TxtAddr.Text), int.Parse(TxtLength.Text));
                        break;
                    case "M":
                        data = Client.Read(BCNetS7200.Type.M, int.Parse(TxtAddr.Text), int.Parse(TxtLength.Text));
                        break;
                }
                if (data != null)
                {
                    TxtDump.Text = BitConverter.ToString(data).Replace('-', ' ');
                    SendByte.Text = BitConverter.ToString(Client.sendbyte).Replace('-', ' ');
                    RecvByte.Text = BitConverter.ToString(Client.recvbyte).Replace('-', ' ');
                }
            }
            catch (Exception ex)
            {
                TxtTime.Text = "Read error : " + ex.Message;
            }
            int Time_ms = Environment.TickCount - Elapsed;
            TxtTime.Text = Time_ms.ToString() + " ms";
        }

        private void WriteBtn_Click(object sender, EventArgs e)
        {
            int Elapsed = Environment.TickCount;
            try
            {
                switch (Area.Text)
                {
                    case "Q":
                        Client.Write(BCNetS7200.Type.Q, int.Parse(TxtAddr.Text), int.Parse(TxtValue.Text));
                        break;
                    case "V":
                        Client.Write(BCNetS7200.Type.V, int.Parse(TxtAddr.Text), int.Parse(TxtValue.Text));
                        break;
                    case "M":
                        Client.Write(BCNetS7200.Type.M, int.Parse(TxtAddr.Text), int.Parse(TxtValue.Text));
                        break;
                }
                SendByte.Text = BitConverter.ToString(Client.sendbyte).Replace('-', ' ');
                RecvByte.Text = BitConverter.ToString(Client.recvbyte).Replace('-', ' ');
            }
            catch (Exception ex)
            {
                TxtTime.Text = "Write error : " + ex.Message;
            }
            int Time_ms = Environment.TickCount - Elapsed;
            TxtTime.Text = Time_ms.ToString() + " ms";
        }
    }
}
