using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modbus_test
{
    public class ModbusASCII
    {
        public ModbusASCII()
        {
            serialPort1 = new System.IO.Ports.SerialPort();
        }

        public System.IO.Ports.SerialPort serialPort1;

        public bool connect(string com, int BaudRate = 9600, int DataBits = 8, System.IO.Ports.StopBits StopBits = System.IO.Ports.StopBits.One, System.IO.Ports.Parity Parity = System.IO.Ports.Parity.Even)
        {
            try
            {
                //*** 设置端口参数*****//
                serialPort1.Close();
                serialPort1.BaudRate = BaudRate;
                serialPort1.DataBits = DataBits;
                serialPort1.StopBits = StopBits;
                serialPort1.Parity = Parity;
                serialPort1.PortName = com;
                //comport.Encoding = Encoding.ASCII;
                serialPort1.Open();//打开端口

                if (serialPort1.IsOpen)
                {
                    //   MessageBox.Show("打开" + com + "端口成功");
                    return true;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("端口打开失败！" + e.Message, "提示");
                throw e;
            }
            return false;
        }

        public bool Disconnect()
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    //       MessageBox.Show("关闭端口成功");
                    return true;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show("端口关闭失败！" + e.Message, "提示");
                throw e;
            }
            return false;
        }

        public byte[] Read()
        {
            byte[] Data = null;

            return Data;
        }
    }
}
