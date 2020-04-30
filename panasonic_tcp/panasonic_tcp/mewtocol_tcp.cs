using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace panasonic_tcp
{
    class mewtocol_tcp : IDisposable
    {
        public bool connected;
        private Socket msock;
        /// <summary>
        /// 发送指令
        /// </summary>
        public byte[] test_string1;
        /// <summary>
        /// 接收指令
        /// </summary>
        public byte[] test_string2;

        /// <summary>
        /// 构造函数（PLC的IP地址、PLC端口号）
        /// </summary>
        /// <param name="ip">IP地址</param>
        /// <param name="port">PLC端口号</param>
        public mewtocol_tcp()
        {
            //this.ip = ip;
            //this.port = port;
            connected = false;
        }
        //~mewtocol_tcp()
        //{
        //    disconn();
        //}

        /// <summary>
        /// IDisposable的接口实现，用于销毁实例
        /// </summary>
        public void Dispose()
        {
            disconn();
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void disconn()
        {
            if (connected)
            {
                if(msock != null)
                {
                    msock.Dispose();
                    msock = null;
                }
                connected = false;
            }
        }

        /// <summary>
        /// 连接PLC
        /// </summary>
        public void conn(string ip, int port)
        {
            if (!connected)
            {
                try
                {
                    msock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    msock.NoDelay = true;
                    //msock.Bind(new IPEndPoint(IPAddress.Parse("192.168.1.11"), port));//指定本机地址及端口
                    msock.Connect(ip, port);
                    connected = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// 读字      D、L     、F（待测试）
        /// </summary>
        /// <param name="DTaddr1">"D1"</param>
        /// <param name="DTaddr2">"D2"</param>
        public byte[] readDT(string DTaddr1, string DTaddr2)
        {
            if (connected)
            {
                byte[] DTbyte = null;
                //地址转换
                string sReg = DTaddr1.Substring(0, 1);//"D"
                string sA1 = DTaddr1.Substring(1, DTaddr1.Length - 1);
                string sA2 = DTaddr2.Substring(1, DTaddr2.Length - 1);
                int iLen = Convert.ToInt16(sA2) - Convert.ToInt16(sA1) + 1;
                sA1 = sA1.PadLeft(5, '0');
                sA2 = sA2.PadLeft(5, '0');
                string sAddr = sReg + sA1 + sA2;
                //
                string outStr = "";
                if (iLen > 109)
                {
                    outStr = "<01#RD" + sAddr;
                }
                else
                {
                    outStr = "%01#RD" + sAddr;
                }
                outStr = outStr + bcc(outStr) + "\r";
                //
                try
                {
                    byte[] command = Encoding.Default.GetBytes(outStr);
                    msock.Send(command);
                    test_string1 = command;
                    byte[] receive = new byte[9 + 4 * iLen];
                    msock.Receive(receive);
                    test_string2 = receive;
                    DTbyte = ReceiveData(receive, iLen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return DTbyte;
            }
            return null;
        }

        /// <summary>
        /// 读位（以字为单位读出）      X、Y、R、L、T、C
        /// </summary>
        /// <param name="DTaddr1"></param>
        /// <param name="DTaddr2"></param>
        public byte[] readMS(string MSaddr1, string MSaddr2)
        {
            if (connected)
            {
                byte[] MSbyte = null;
                //地址转换
                string sReg = MSaddr1.Substring(0, 1);
                string sA1 = MSaddr1.Substring(1, MSaddr1.Length - 1).PadLeft(4, '0');
                string sA2 = MSaddr2.Substring(1, MSaddr2.Length - 1).PadLeft(4, '0');
                int iLen = Convert.ToInt16(sA2) - Convert.ToInt16(sA1) + 1;
                //
                string outStr = "";
                if (iLen > 109)
                {
                    outStr = "<01#RCC" + sReg + sA1 + sA2;
                }
                else
                {
                    outStr = "%01#RCC" + sReg + sA1 + sA2;
                }
                outStr = outStr + bcc(outStr) + "\r";
                //
                try
                {
                    byte[] command = Encoding.Default.GetBytes(outStr);
                    msock.Send(command);
                    test_string1 = command;
                    byte[] receive = new byte[9 + 4 * iLen];
                    msock.Receive(receive);
                    test_string2 = receive;
                    MSbyte = ReceiveData(receive, iLen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return MSbyte;
            }
            return null;
        }

        /// <summary>
        /// 写字      D、L     、F（待测试）
        /// </summary>
        /// <param name="DTaddr1"></param>
        /// <param name="DTaddr2"></param>
        /// <param name="value"></param>
        public void writeDT(string DTaddr1, int value)
        {
            if (connected)
            {
                //地址转换
                string sReg = DTaddr1.Substring(0, 1);//"D"
                string sA1 = DTaddr1.Substring(1, DTaddr1.Length - 1);
                string sA2 = DTaddr1.Substring(1, DTaddr1.Length - 1);
                sA1 = sA1.PadLeft(5, '0');
                sA2 = sA2.PadLeft(5, '0');
                string sAddr = sReg + sA1 + sA2;
                //数值转换
                string sValue = "";
                sValue = (value).ToString(); //((int)(value[i] * 1000)).ToString();
                sValue = Convert.ToInt32(sValue).ToString("X4");
                sValue = sValue.Substring(2, 2) + sValue.Substring(0, 2);//1,0,2,3
                //int iLen = Convert.ToInt16(sA2) - Convert.ToInt16(sA1) + 1;
                //
                string outStr = "";
                //if (iLen > 109)
                //{
                //    outStr = "<01#WD" + sAddr + sValues;
                //}
                //else
                //{
                //    outStr = "%01#WD" + sAddr + sValues;
                //}
                outStr = "%01#WD" + sAddr + sValue;
                outStr = outStr + bcc(outStr) + "\r";
                //
                try
                {
                    byte[] command = Encoding.Default.GetBytes(outStr);
                    msock.Send(command);
                    test_string1 = command;
                    byte[] receive = new byte[9];
                    msock.Receive(receive);
                    test_string2 = receive;
                    ReceiveData(receive);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return;
        }

        public void writeDT(string DTaddr1, ushort[] value)
        {
            if (connected)
            {
                //地址转换
                string sReg = DTaddr1.Substring(0, 1);//"D"
                string sA1 = DTaddr1.Substring(1, DTaddr1.Length - 1);
                int addr2 = Convert.ToInt16(sA1) + value.Length - 1;
                string sA2 = addr2.ToString();
                sA1 = sA1.PadLeft(5, '0');
                sA2 = sA2.PadLeft(5, '0');
                string sAddr = sReg + sA1 + sA2;
                string sValues = "";
                string sValue = "";
                for (int i = 0; i < value.Length; i++)
                {
                    sValue = (value).ToString(); //((int)(value[i] * 1000)).ToString();
                    sValue = Convert.ToInt32(sValue).ToString("X4");
                    sValue = sValue.Substring(2, 2) + sValue.Substring(0, 2);//1,0,2,3
                    sValues += sValue;
                }
                string outStr = "";
                int iLen = Convert.ToInt16(sA2) - Convert.ToInt16(sA1) + 1;
                if (iLen > 109)
                {
                    outStr = "<01#WD" + sAddr + sValues;
                }
                else
                {
                    outStr = "%01#WD" + sAddr + sValues;
                }
                outStr = outStr + bcc(outStr) + "\r";
                //
                try
                {
                    byte[] command = Encoding.Default.GetBytes(outStr);
                    msock.Send(command);
                    test_string1 = command;
                    byte[] receive = new byte[9];
                    msock.Receive(receive);
                    test_string2 = receive;
                    ReceiveData(receive);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return;
        }

        /// <summary>
        /// 写单个位点
        /// </summary>
        /// <param name="XYMaddr"></param>
        /// <param name="value"></param>
        public void setM(string XYMaddr, bool value)
        {
            //地址转换
            string sReg = XYMaddr.Substring(0, 1);
            string sAddr = XYMaddr.Substring(1, XYMaddr.Length - 1).PadLeft(4, '0');
            //int iLen = Convert.ToInt16(sA2) - Convert.ToInt16(sA1) + 1;
            //
            string outStr = "";
            outStr = "%01#WCS" + sReg + sAddr;
            if(value)
            {
                outStr += "1";
            }
            else
            {
                outStr += "0";
            }
            outStr = outStr + bcc(outStr) + "\r";
            //
            try
            {
                byte[] command = Encoding.Default.GetBytes(outStr);
                msock.Send(command);
                test_string1 = command;
                byte[] receive = new byte[9];
                msock.Receive(receive);
                test_string2 = receive;
                ReceiveData(receive);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return;
        }

        /// <summary>
        /// bcc码
        /// </summary>
        /// <param name="chkString"></param>
        /// <returns></returns>
        private static string bcc(string chkString)
        {
            int chkSum = 0;
            string chkSums = "";
            int k;
            for (k = 0; k < chkString.Length; k++)
            {
                chkSum = chkSum ^ Asc(chkString.Substring(k, 1));
            }
            chkSums = Convert.ToString(chkSum, 16);
            chkSums = chkSums.PadLeft(2, '0');  //补齐两位
            return chkSums.Substring(chkSums.Length - 2, 2).ToUpper();  //截成两位
        }

        /// <summary>
        /// 转换为ASCII码
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        private static int Asc(string character)
        {
            if (character.Length == 1)
            {
                ASCIIEncoding asciiEncoding = new ASCIIEncoding();
                int intAsciiCode = (int)asciiEncoding.GetBytes(character)[0];
                return (intAsciiCode);
            }
            else
            {
                throw new Exception("Character is not valid");
            }
        }

        /// <summary>
        /// 数据接收处理
        /// </summary>
        /// <param name="message"></param>
        /// <param name="length"></param>
        public byte[] ReceiveData(byte[] message, int length = 1)
        {
            byte[] DTbyte = null;
            switch (message[3])
            {
                case 0x24://正常
                    switch (message[4])
                    {
                        case 0x52:
                            string[] temp_string = new string[length];

                            switch (message[5])
                            {
                                case 0x44://RD
                                    //DTbyte = new byte[length];
                                    List<byte> values = new List<byte>();
                                    for (int i = 0; i < length; i++)
                                    {
                                        temp_string[i] = Encoding.Default.GetString(message, 6 + i * 4 + 2, 2) + Encoding.Default.GetString(message, 6 + i * 4, 2);
                                        short value = Convert.ToInt16(temp_string[i], 16);//字符串转16进制16位有符号整数
                                        byte[] right_value = new byte[2];
                                        right_value[1] = BitConverter.GetBytes(value)[0];
                                        right_value[0] = BitConverter.GetBytes(value)[1];
                                        values.AddRange(right_value);//16位有符号，两个字节
                                    }
                                    DTbyte = values.ToArray();
                                    break;
                                case 0x43://RC
                                    DTbyte = new byte[length];
                                    for (int i = 0; i < length; i++)
                                    {
                                        temp_string[i] = Encoding.Default.GetString(message, 6 + i * 4 + 2, 2) + Encoding.Default.GetString(message, 6 + i * 4, 2);
                                        DTbyte[i] = Convert.ToByte(temp_string[i], 16);
                                    }
                                    break;
                            }
                            break;
                        case 0x57:
                            switch (message[5])
                            {
                                case 0x44://WD
                                    //写入成功
                                    break;
                                case 0x43://WC
                                    //写入成功
                                    break;
                            }
                            break;
                    }
                    break;
                case 0x21://错误
                    byte[] error = new byte[2];
                    Array.Copy(message, 4, error, 0, 2);
                    //
                    break;
            }
            return DTbyte;
        }
    }
}
