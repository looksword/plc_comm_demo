using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modbus_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //自动获取COM口名称
            foreach (string com in System.IO.Ports.SerialPort.GetPortNames())
            {
                comportName_rtu.Items.Add(com);
                comportName_rtu.SelectedIndex = 0;
                comportName_ascii.Items.Add(com);
                comportName_ascii.SelectedIndex = 0;
            }
            baudRate_rtu.SelectedIndex = 0;
            Parity_rtu.SelectedIndex = 0;//Even
            baudRate_ascii.SelectedIndex = 0;
            Parity_ascii.SelectedIndex = 0;//Even
        }

        #region Modbus Rtu

        private ModbusRTU modbusrtu = null;

        private void connectPLC_com_Click(object sender, EventArgs e)
        {
            try
            {
                if (modbusrtu == null)
                {
                    modbusrtu = new ModbusRTU();
                }
                System.IO.Ports.StopBits stopbits = System.IO.Ports.StopBits.One;
                System.IO.Ports.Parity parity = System.IO.Ports.Parity.Even;
                if (modbusrtu.serialPort1.IsOpen)
                {
                    if (modbusrtu.Disconnect())
                    { this.connectPLC_RTU.Text = "连接"; }
                }
                else
                {
                    switch (Parity_rtu.Text)
                    {
                        case "Even":
                            parity = System.IO.Ports.Parity.Even;
                            break;
                        case "None":
                            parity = System.IO.Ports.Parity.None;
                            stopbits = System.IO.Ports.StopBits.Two;
                            break;
                        case "Odd":
                            parity = System.IO.Ports.Parity.Odd;
                            break;
                    }
                    if (modbusrtu.connect(this.comportName_rtu.Text, int.Parse(this.baudRate_rtu.Text), 8, stopbits, parity))
                    { this.connectPLC_RTU.Text = "断开"; }
                }
            }
            catch(Exception ex)
            {
                txt_rtu.Text = "Connect Error : " + ex.Message;
            }
        }

        private void station_rtu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int station = Int32.Parse(station_rtu.Text);
            }
            catch (Exception ex)
            { 
                txt_rtu.Text = "Station Error : " + ex.Message; 
            }
        }

        private void read_rtu_Click(object sender, EventArgs e)
        {
            try
            {
                ModbusRTU.Area area = ModbusRTU.Area.Coil;
                switch (area_rtu.Text)
                {
                    case "coil":
                        area = ModbusRTU.Area.Coil;
                        break;
                    case "input":
                        area = ModbusRTU.Area.Input;
                        break;
                    case "Register":
                        area = ModbusRTU.Area.Register;
                        break;
                    case "InputRegister":
                        area = ModbusRTU.Area.InputRegister;
                        break;
                    default:
                        throw new Exception("未选择区域");
                }
                modbusrtu.Station = byte.Parse(station_rtu.Text);
                byte[] data = modbusrtu.Read(area, ushort.Parse(address_rtu.Text), int.Parse(length_rtu.Text));
                send_rtu.Text = BitConverter.ToString(modbusrtu.sendmessage).Replace("-", " ");
                recv_rtu.Text = BitConverter.ToString(modbusrtu.recvmessage).Replace("-", " ");
                data_rtu.Text = BitConverter.ToString(data).Replace("-", " ");
            }
            catch(Exception ex)
            {
                txt_rtu.Text = "Read Error : " + ex.Message;
            }
        }

        private void write_rtu_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                txt_rtu.Text = "Write Error : " + ex.Message;
            }
        }

        #endregion

        #region Modbus Ascii

        private ModbusASCII modbusascii = null;

        private void connectPLC_ASCII_Click(object sender, EventArgs e)
        {
            try
            {
                if (modbusascii == null)
                {
                    modbusascii = new ModbusASCII();
                }
                System.IO.Ports.StopBits stopbits = System.IO.Ports.StopBits.One;
                System.IO.Ports.Parity parity = System.IO.Ports.Parity.Even;
                if (modbusascii.serialPort1.IsOpen)
                {
                    if (modbusascii.Disconnect())
                    { this.connectPLC_ASCII.Text = "连接"; }
                }
                else
                {
                    switch (Parity_ascii.Text)
                    {
                        case "Even":
                            parity = System.IO.Ports.Parity.Even;
                            break;
                        case "None":
                            parity = System.IO.Ports.Parity.None;
                            stopbits = System.IO.Ports.StopBits.Two;
                            break;
                        case "Odd":
                            parity = System.IO.Ports.Parity.Odd;
                            break;
                    }
                    if (modbusascii.connect(this.comportName_ascii.Text, int.Parse(this.baudRate_ascii.Text), 7, stopbits, parity))
                    { this.connectPLC_ASCII.Text = "断开"; }
                }
            }
            catch(Exception ex)
            {
                txt_rtu.Text = "Connect Error : " + ex.Message;
            }
        }

        private void station_ascii_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int station = Int32.Parse(station_ascii.Text);
            }
            catch (Exception ex)
            {
                txt_rtu.Text = "Station Error : " + ex.Message;
            }
        }

        private void read_ascii_Click(object sender, EventArgs e)
        {
            try
            {
                ModbusASCII.Area area = ModbusASCII.Area.Coil;
                switch(area_ascii.Text)
                {
                    case "coil":
                        area = ModbusASCII.Area.Coil;
                        break;
                    case "input":
                        area = ModbusASCII.Area.Input;
                        break;
                    case "Register":
                        area = ModbusASCII.Area.Register;
                        break;
                    case "InputRegister":
                        area = ModbusASCII.Area.InputRegister;
                        break;
                    default:
                        throw new Exception("未选择区域");
                }
                modbusascii.Station = byte.Parse(station_ascii.Text);
                byte[] data = modbusascii.Read(area, ushort.Parse(address_ascii.Text), int.Parse(length_ascii.Text));
                send_ascii.Text = BitConverter.ToString(modbusascii.sendmessage).Replace("-", " ");
                recv_ascii.Text = BitConverter.ToString(modbusascii.recvmessage).Replace("-", " ");
                data_ascii.Text = BitConverter.ToString(data).Replace("-", " ");
            }
            catch(Exception ex)
            {
                txt_ascii.Text = "Read Error : " + ex.Message;
            }
        }

        private void write_ascii_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                txt_rtu.Text = "Write Error : " + ex.Message;
            }
        }

        #endregion

        #region Modbus Tcp

        private void connectPLC_net_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
