using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ppi_test
{
    class PPI
    {
        public PPI()
        {
            serialPort1 = new System.IO.Ports.SerialPort();
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
        }

        public System.IO.Ports.SerialPort serialPort1;
        public byte[] Data;
        public byte num;//批次

        public bool connect(string com, Int16 BaudRate = 9600)
        {
            try
            {
                //*** 设置端口参数*****//
                serialPort1.Close();
                serialPort1.BaudRate = BaudRate;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = System.IO.Ports.StopBits.One;
                serialPort1.Parity = System.IO.Ports.Parity.Even;
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
                MessageBox.Show("端口打开失败！" + e.Message, "提示");
                return false;
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
                MessageBox.Show("端口关闭失败！" + e.Message, "提示");
                return false;
            }
            return false;

        }

        public void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int length = serialPort1.BytesToRead;
            byte[] data = new byte[length];
            byte[] tmpdata = { 0, 0, 0, 0 };
            //int ae = 0;
            try
            {
                if (length > 0)
                {
                    //byte[] data = new byte[length];
                    serialPort1.Read(data, 0, length);
                    serialPort1.DiscardInBuffer();
                    //MessageBox.Show( BitConverter.ToString(data).Replace("-", " "));
                    //如果接收到的数据长度为1，值为E5H (229)，则为确认码，返回读写确认命令

                    if (length > 25)
                    {
                        //MessageBox.Show(BitConverter.ToString(data).Replace("-", " "));
                        if (data[21] == 0xFF)
                        {
                            Data = new byte[data.Length - 27];
                            Array.Copy(data, 25, Data, 0, Data.Length);
                            //MessageBox.Show(BitConverter.ToString(Data).Replace("-", " "));
                        }
                    }
                    if (length == 24)
                    {//写返回
                        bool write_ok = data[21] == 0xFF ? true : false;
                    }
                    if (data[0] == (byte)229 && data.Length == 1)
                    {
                        //收到数据
                        byte[] dataSend = new byte[6];
                        dataSend[0] = 16;
                        //站号
                        dataSend[1] = 0x02;
                        dataSend[2] = 0x00;
                        dataSend[3] = 0x5C;
                        dataSend[4] = (byte)(dataSend[3] + dataSend[1]);
                        dataSend[5] = 0x16;
                        serialPort1.DiscardOutBuffer();
                        serialPort1.DiscardInBuffer();
                        Thread.Sleep(50);
                        serialPort1.Write(dataSend, 0, dataSend.Length);
                        Thread.Sleep(100);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public byte[] Read(Typ tp = Typ.Q, Siz sz = Siz.bit, int Address = 0, int Length = 1, int StationNO = 2)
        {
            this.Data = null;
            byte[] data = new byte[33];
            data[0] = 0x68;
            data[1] = 0x1B;
            data[2] = 0x1B;
            data[3] = 0x68;
            data[4] = (byte)StationNO;
            data[5] = 0x00;
            data[6] = 0x6C;
            data[7] = 0x32;
            data[8] = 0x01;
            data[9] = 0x00;
            data[10] = 0x00;
            data[11] = 0x00;
            data[12] = num; num++;// 0x00;//批次
            data[13] = 0x00;
            data[14] = 0x0E;
            data[15] = 0x00;
            data[16] = 0x00;
            data[17] = 0x04;
            data[18] = 0x01;
            data[19] = 0x12;
            data[20] = 0x0A;
            data[21] = 0x10;
            switch (sz)
            {
                case Siz.bit:
                    data[22] = 0x01;//(byte)sz; //长度 
                    break;
                case Siz.B:
                    data[22] = 0x02;//Siz.B 2  Siz.W 4  Siz.D 6
                    break;
                case Siz.W:
                    data[22] = 0x04;//Siz.B 2  Siz.W 4  Siz.D 6
                    break;
                case Siz.D:
                    data[22] = 0x06;//Siz.B 2  Siz.W 4  Siz.D 6
                    break;
                default:
                    break;
            }
            switch (tp)
            {
                case Typ.T:
                    data[22] = 0x1F;
                    break;
                case Typ.C:
                    data[22] = 0x1E;
                    break;
                case Typ.HC: 
                    data[22] = 0x20;
                    break;
                default:
                    break;
            }
            data[23] = 0x00;
            data[24] = BitConverter.GetBytes(Length)[0];//个数//小于0xDE//Siz.B
            if (Siz.bit == sz)
                data[24] = 0x01;
            data[25] = 0x00;
            if (Typ.V == tp)
            { data[26] = 0x01; }//存储器类型
            else
            { data[26] = 0x00; }//存储器类型
            data[27] = (byte)tp;//存储器类型
            data[28] = 0x00;
            if (Siz.bit == sz)
            {
                Address = Address / 10 * 8 + Address % 10;//八进制换成十进制
                data[29] = Convert.ToByte(Address / 256);
                data[30] = Convert.ToByte(Address % 256);

            }
            else
            {
                data[29] = Convert.ToByte(Address * 8 / 256);
                data[30] = Convert.ToByte(Address * 8 % 256);

            }
            if (tp == Typ.T || tp == Typ.C || tp == Typ.HC)//
            {
                data[29] = Convert.ToByte(Address / 256);
                data[30] = Convert.ToByte(Address % 256);
            }
            int j = 0;
            for (int i = 4; i <= 30; i++)
            {
                j = j + Convert.ToInt32(data[i]);
            }
            data[31] = Convert.ToByte(j % 256);
            data[32] = 0x16;
            try
            {

                if (this.serialPort1.IsOpen)
                {
                    Thread.Sleep(10);
                    serialPort1.Write(data, 0, data.Length);
                    //throw new Exception(BitConverter.ToString(data).Replace("-"," "));
                    //MessageBox.Show(BitConverter.ToString(data).Replace("-", " "));
                }
                else
                {
                    //MessageBox.Show("端口尚未打开");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
            Thread.Sleep(250);
            return this.Data;
        }

        public void Write(Typ tp = Typ.Q, Siz sz = Siz.bit, int Address = 0, Int32 Value = 1, int StationNO = 2)
        {
            byte[] data;
            int j;
            data = new byte[39];
            data[1] = 0x21;
            data[2] = 0x21;
            //if (Siz.W == sz)
            //{
            //    data = new byte[39];
            //    data[1] = 0x21;
            //    data[2] = 0x21;
            //}
            //else
            //{
            //    if (Siz.D == sz)
            //    {
            //        data = new byte[41];
            //        data[1] = 0x23;
            //        data[2] = 0x23;
            //    }
            //    else
            //    {
            //        data = new byte[38];
            //        data[1] = 0x20;
            //        data[2] = 0x20;
            //    }
            //}
            data[0] = 0x68;
            data[3] = 0x68;
            data[4] = (byte)StationNO; //站号
            data[5] = 0x00;
            data[6] = 0x7C; //功能码(写入)
            data[7] = 0x32;
            data[8] = 0x01;
            data[9] = 0x00;
            data[10] = 0x00;
            data[11] = 0x00;
            data[12] = num; num++;// 0x00;//批次
            data[13] = 0x00;
            data[14] = 0x0E;
            data[15] = 0x00;
            data[16] = 0x06;//0x05;//数据区长度
            data[17] = 0x05;
            data[18] = 0x01;
            data[19] = 0x12;
            data[20] = 0x0A;
            data[21] = 0x10;
            data[22] = 0x02;//(byte)sz; //长度 
            data[23] = 0x00;
            data[24] = 0x01;
            data[25] = 0x00;
            if (Typ.V == tp)
            { data[26] = 0x01; }//存储器类型
            else
            { data[26] = 0x00; }//存储器类型
            data[27] = (byte)tp;//存储器类型
            data[28] = 0x00;
            data[31] = 0x00;
            data[33] = 0x00;

            if (Siz.bit == sz)
            {
                Address = Address / 10 * 8 + Address % 10;
                data[29] = Convert.ToByte(Address / 256);
                data[30] = Convert.ToByte(Address % 256);
                data[32] = 0x03;
            }
            else
            {
                data[29] = Convert.ToByte(Address * 8 / 256);
                data[30] = Convert.ToByte(Address * 8 % 256);
                data[32] = 0x04;
            }

            if (Siz.W == sz)
            {

                data[34] = 0x10;//位数 
                data[35] = Convert.ToByte(Value / 256);
                data[36] = Convert.ToByte(Value % 256);
                j = 0;
                for (int i = 4; i <= 36; i++)
                    j = j + data[i];
                data[37] = Convert.ToByte(j % 256);
                data[38] = 0x16;

            }
            else
            {
                if (Siz.D == sz)
                {
                    data[34] = 0x20;//位数 
                    data[35] = Convert.ToByte((Value >> 24) % 256);
                    data[36] = Convert.ToByte((Value >> 16) % 256);
                    data[37] = Convert.ToByte((Value >> 8) % 256);
                    data[38] = Convert.ToByte(Value % 256);
                    j = 0;
                    for (int i = 4; i <= 38; i++)
                        j = j + data[i];
                    data[39] = Convert.ToByte(j % 256);
                    data[40] = 0x16;
                }
                else
                {
                    if (Siz.bit == sz) { data[34] = 0x01; }
                    if (Siz.B == sz) { data[34] = 0x08; }
                    data[35] = (byte)Value;
                    data[36] = 0x00;
                    j = 0;
                    for (int i = 4; i <= 36; i++)
                        j = j + data[i];
                    data[37] = Convert.ToByte(j % 256);
                    data[38] = 0x16;
                    //data[35] = (byte)Value;

                    ////效验和
                    //j = 0;
                    //for (int i = 4; i <= 35; i++)
                    //    j = j + data[i];
                    //data[36] = Convert.ToByte(j % 256);
                    //data[37] = 0x16;
                }
            }

            try
            {

                if (this.serialPort1.IsOpen)
                {
                    Thread.Sleep(10);
                    serialPort1.Write(data, 0, data.Length);
                    //MessageBox.Show(BitConverter.ToString(data).Replace("-", " "));
                }
                else
                {
                    MessageBox.Show("端口尚未打开");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public enum Typ
        {
            S = 0x04, SM = 0x05,
            AI = 0x06, AQ = 0x07,
            C = 0x1E, T = 0x1F, HC = 0x20,
            I = 0x81, Q = 0x82,
            M = 0x83, V = 0x84
        };
        public enum Siz { bit = 0x01, B = 0x02, W = 0x04, D = 0x06 };
    }
}
