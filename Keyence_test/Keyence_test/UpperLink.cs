using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Keyence_test
{
    /// <summary>
    /// 上位链路协议
    /// 
    /// 数据格式
    /// .U  16位无符号十进制数      5个字节
    /// .S  16位有符号十进制数      6个字节
    /// .D  32位无符号十进制数      10个字节
    /// .L  32位有符号十进制数      11个字节
    /// .H  16位十六进制数            4个字节            
    /// 
    /// </summary>
    public class UpperLink
    {
        public bool connected;
        Socket msock;
        public string receive_string;

        public UpperLink()
        {
            connected = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port">上位链路默认为8501</param>
        public void Conn(string ip, int port = 8501)
        {
            if (!connected)
            {
                try
                {
                    msock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    //msock.Bind(new IPEndPoint(IPAddress.Parse("192.168.0.10"), port));//指定本机地址及端口
                    msock.Connect(ip, port);
                    connected = true;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                connected = true;
            }
        }

        public void Disconn()
        {
            if (connected)
            {
                if (msock != null)
                {
                    msock.Close();
                }
                connected = false;
            }
        }

        /// <summary>
        /// 读单个位点
        /// </summary>
        /// <param name="area"></param>
        /// <param name="addr"></param>
        /// <returns></returns>
        public byte[] Readbit(string area, int addr)
        {
            if (connected)
            {
                try
                {
                    return ReadbitS(area, addr, 1);
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("msock 未连接");
            }
        }

        /// <summary>
        /// 读多个位点
        /// </summary>
        /// <param name="area"></param>
        /// <param name="addr"></param>
        /// <param name="num"></param>
        public byte[] ReadbitS(string area, int addr, int num)
        {
            if (connected)
            {
                receive_string = "";
                //
                string outStr = "RDS ";

                outStr = outStr + area + addr.ToString() + " " + num + "\r";
                //
                try
                {
                    byte[] command = Encoding.Default.GetBytes(outStr);
                    msock.Send(command);
                    byte[] receive = new byte[2 * num + 1];
                    msock.Receive(receive);
                    return ReceiveData(receive, 2 * num - 1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("msock 未连接");
            }
        }

        /// <summary>
        /// 读字
        /// </summary>
        /// <param name="area"></param>
        /// <param name="addr"></param>
        /// <param name="num"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public byte[] ReadDS(string area, int addr, int num, string type = ".D")
        {
            if (connected)
            {
                receive_string = "";
                int wordlen;//字节大小加一（有空格）
                switch (type)
                {
                    case ".S"://16位有符号十进制数
                        wordlen = 7;
                        break;
                    case ".U"://16位无符号十进制数
                        wordlen = 6;
                        break;
                    case ".D"://32位无符号十进制数
                        wordlen = 11;
                        break;
                    case ".H"://16位十六进制数
                        wordlen = 5;
                        break;
                    case ".L"://32位有符号十进制数
                        wordlen = 12;
                        break;
                    default:
                        wordlen = 12;
                        break;
                }
                //
                string outStr = "RDS ";

                outStr = outStr + area + addr.ToString() + type + " " + num + "\r";
                //
                try
                {
                    byte[] command = Encoding.Default.GetBytes(outStr);
                    msock.Send(command);
                    byte[] receive = new byte[wordlen * num + 1];
                    msock.Receive(receive);
                    return ReceiveData(receive, wordlen * num - 1);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("msock 未连接");
            }
        }

        public byte[] ReceiveData(byte[] message, int length)
        {
            if (message[0] == 0x45)
            {
                switch (message[1])
                {
                    case 0x30:
                        //软元件编号异常
                        throw new Exception("软元件编号异常");
                    case 0x31:
                        //命令异常
                        throw new Exception("命令异常");
                    case 0x34:
                        //禁止写入
                        throw new Exception("禁止写入");
                }
            }
            receive_string = Encoding.ASCII.GetString(message, 0, length);
            string[] data = receive_string.Split(' ');
            byte[] DTbyte = new byte[length];
            for (int i = 0; i < length; i++)
            {
                DTbyte[i] = (byte)Convert.ToInt32(data[i]);
            }
            return DTbyte;
        }

        public bool WriteB(string area, int addr, bool value)
        {
            if (connected)
            {
                receive_string = "";
                //
                string outStr = "WR ";

                outStr = outStr + area + addr.ToString();

                outStr = outStr + " " + (value ? 1 : 0).ToString() + "\r";
                //
                try
                {
                    byte[] command = Encoding.Default.GetBytes(outStr);
                    msock.Send(command);
                    byte[] receive = new byte[4];
                    msock.Receive(receive);
                    ReceiveData(receive, 1);
                    if (receive[0] == 0x4F)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return false;
        }

        public bool WriteBS(string area, int addr, string[] datas)
        {
            if (connected)
            {
                receive_string = "";
                //
                string outStr = "WRS ";
                outStr = outStr + area + addr.ToString() + " " + datas.Length.ToString();
                foreach (string data in datas)
                {
                    outStr += " ";
                    outStr += data;
                }
                outStr += "\r";
                //
                try
                {
                    byte[] command = Encoding.Default.GetBytes(outStr);
                    msock.Send(command);
                    byte[] receive = new byte[4];
                    msock.Receive(receive);
                    ReceiveData(receive, 1);
                    if (receive[0] == 0x4F)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return false;
        }

        public bool WriteDS(string area, int addr, string[] datas)
        {
            if (connected)
            {
                //
                string outStr = "WRS ";
                outStr = outStr + area + addr.ToString() + ".D" + " " + datas.Length.ToString();
                foreach (string data in datas)
                {
                    outStr += " ";
                    outStr += data;
                }
                outStr += "\r";
                //
                try
                {
                    byte[] command = Encoding.Default.GetBytes(outStr);
                    msock.Send(command);
                    byte[] receive = new byte[4];
                    msock.Receive(receive);
                    if (receive[0] == 0x4F)
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return false;
        }
    }
}
