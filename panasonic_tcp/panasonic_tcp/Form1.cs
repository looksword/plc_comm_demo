using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panasonic_tcp
{
    public partial class Form1 : Form
    {
        private mewtocol_tcp mewtocol_Tcp = null;

        private int address;

        public Form1()
        {
            InitializeComponent();
            mewtocol_Tcp = new mewtocol_tcp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            address = 0;
            address_.Text = Convert.ToString(address);
            count.Text = "1";
            //mewtocol_Tcp.conn();
            //byte[] DTvalue;
            //string data;
            //DTvalue = mewtocol_Tcp.readDT("L11", "L12");
            //data = mewtocol_Tcp.test_data;
            //mewtocol_Tcp.readMS("Y1", "Y2");
            //DTvalue = mewtocol_Tcp.DTbyte;
            //data = mewtocol_Tcp.test_data;
            //mewtocol_Tcp.readMS("R1", "R3");
            //DTvalue = mewtocol_Tcp.DTbyte;
            //data = mewtocol_Tcp.test_data;
            //mewtocol_Tcp.readMS("L1", "L4");
            //DTvalue = mewtocol_Tcp.DTbyte;
            //data = mewtocol_Tcp.test_data;
            //mewtocol_Tcp.readMS("T1", "T5");
            //DTvalue = mewtocol_Tcp.DTbyte;
            //data = mewtocol_Tcp.test_data;
            //mewtocol_Tcp.readMS("C1", "C6");
            //DTvalue = mewtocol_Tcp.DTbyte;
            //data = mewtocol_Tcp.test_data;
            //DateTime aaa = DateTime.Now;
            //DateTime bbb;
            //TimeSpan ccc;
            //List<byte[]> temp_test = new List<byte[]>();
            //bool readplc = true;
            //while (readplc)
            //{
            //    mewtocol_Tcp.readDT("D1", "D20");
            //    temp_test.Add(mewtocol_Tcp.DTbyte);
            //    bbb = DateTime.Now;
            //    ccc = bbb - aaa;
            //    //aaa = bbb;
            //    if (ccc.TotalMilliseconds > 1000)
            //        readplc = false;
            //}
            //mewtocol_Tcp.disconn();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (mewtocol_Tcp == null)
            {
                mewtocol_Tcp = new mewtocol_tcp();
            }
            mewtocol_Tcp.conn(TxtIP.Text, int.Parse(TxtPort.Text));
            ConnectBtn.Enabled = false;
            DisconnectBtn.Enabled = true;
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            mewtocol_Tcp.disconn();
            ConnectBtn.Enabled = true;
            DisconnectBtn.Enabled = false;
        }

        private void read_Click(object sender, EventArgs e)
        {
            return_value.Text = "";
            byte[] data = null;
            switch(address_type.Text)
            {
                case "D":
                case "L":
                    data = mewtocol_Tcp.readDT(address_type.Text + address.ToString(), address_type.Text + (address + int.Parse(count.Text) - 1).ToString());
                    break;
                case "X":
                case "Y":
                case "R":
                case "T":
                case "C":
                    data = mewtocol_Tcp.readMS(address_type.Text + address.ToString(), address_type.Text + (address + int.Parse(count.Text) - 1).ToString());
                    break;
                case "LM":
                    data = mewtocol_Tcp.readMS("L" + address.ToString(), "L" + (address + int.Parse(count.Text) - 1).ToString());
                    break;
            }
            string outputstring = "";
            outputstring += Encoding.ASCII.GetString(mewtocol_Tcp.test_string1) + Environment.NewLine;
            outputstring += BitConverter.ToString(mewtocol_Tcp.test_string1).Replace("-", " ") + Environment.NewLine;
            outputstring += Encoding.ASCII.GetString(mewtocol_Tcp.test_string2) + Environment.NewLine;
            outputstring += BitConverter.ToString(mewtocol_Tcp.test_string2).Replace("-", " ") + Environment.NewLine;
            if (data != null)
            {
                outputstring += BitConverter.ToString(data).Replace("-", " ");
            }
            return_value.Text = outputstring;
        }

        private void wirte_Click(object sender, EventArgs e)
        {
            return_value.Text = "";
            switch(address_type.Text)
            {
                case "D":
                case "L":
                    int int_Value = Convert.ToInt32(write_value.Text);
                    mewtocol_Tcp.writeDT(address_type.Text + address.ToString(), int_Value);
                    break;
                case "Y":
                case "R":
                    bool bit_Value = Convert.ToBoolean(bitValue.Text);
                    mewtocol_Tcp.setM(address_type.Text + address.ToString(), bit_Value);
                    break;
            }
            string outputstring = "";
            outputstring += Encoding.ASCII.GetString(mewtocol_Tcp.test_string1) + Environment.NewLine;
            outputstring += BitConverter.ToString(mewtocol_Tcp.test_string1).Replace("-", " ") + Environment.NewLine;
            outputstring += Encoding.ASCII.GetString(mewtocol_Tcp.test_string2) + Environment.NewLine;
            outputstring += BitConverter.ToString(mewtocol_Tcp.test_string2).Replace("-", " ") + Environment.NewLine;
            return_value.Text = outputstring;
        }

        private void address_reduce_Click(object sender, EventArgs e)
        {
            address--;
            address_.Text = Convert.ToString(address);
        }

        private void address_add_Click(object sender, EventArgs e)
        {
            address++;
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
    }
}
