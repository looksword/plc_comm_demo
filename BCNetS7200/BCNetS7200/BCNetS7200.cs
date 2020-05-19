using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace BCNetS7200
{
    public class BCNetS7200
    {
        public bool connected;
        private Socket sockets;
        public byte[] sendbyte = null;
        public byte[] recvbyte = null;

        public BCNetS7200()
        {
            connected = false;
        }

        public void Connect(string ip,int port)
        {
            if (!connected)
            {
                try
                {
                    sockets = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    sockets.Connect(ip, port);
                    connected = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Disconnect()
        {
            if(connected)
            {
                if(sockets!=null)
                {
                    sockets.Close();
                }
                connected = false;
            }
        }

        public byte[] Read(Type type, int address, int length)
        {
            byte[] data = null;
            try
            {
                byte[] Cmd = BulidReadCmd(type, address, length);
                sendbyte = Cmd;
                if (connected)
                {

                    sockets.Send(Cmd);
                    byte[] buffer = new byte[16+length];//读取返回报文最大长度
                    int receive = sockets.Receive(buffer);
                    recvbyte = buffer;
                    if (receive > 16)
                    {
                        int len = buffer[13];
                        data = new byte[len];
                        Array.Copy(buffer, 16, data, 0, len);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return data;
        }

        public void Write(Type type,int address,int Value)
        {
            try
            {
                byte[] Cmd = BulidWriteCmd(type, address, (byte)Value);
                sendbyte = Cmd;
                if (connected)
                {
                    sockets.Send(Cmd);
                    byte[] buffer = new byte[16];//写入返回报文最大长度
                    int receive = sockets.Receive(buffer);
                    recvbyte = buffer;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private byte[] BulidReadCmd(Type type, int address, int length)
        {
            byte[] cmd = new byte[16];
            //报文头
            cmd[0] = 0x03;//客户端
            cmd[1] = 0xFF;//服务端
            cmd[2] = 0x08;//扩展报文头及用户数据总长度
            cmd[3] = (byte)CmdNum++;//
            cmd[4] = 0x00;//响应号
            cmd[5] = 0x00;//错误号
            switch (type)
            {//命令号
                case Type.V:
                    cmd[6] = 0x31;
                    break;
                case Type.M:
                    cmd[6] = 0x33;
                    break;
                case Type.I:
                    cmd[6] = 0x34;
                    break;
                case Type.Q:
                    cmd[6] = 0x34;
                    break;
            }
            cmd[7] = 0x00;//扩展号
            //扩展报文头
            cmd[8] = StationNo;//PLC站号
            switch (type)
            {//地址
                case Type.V:
                    cmd[9] = (byte)(address / 256);//起始地址的高8位
                    cmd[10] = 0x00;//DB号高位
                    cmd[11] = 0x01;//DB号低位
                    cmd[12] = (byte)(address % 256);//起始地址的低8位
                    break;
                case Type.M:
                    cmd[9] = 0x00;
                    cmd[10] = (byte)(address / 256);//起始地址的高8位
                    cmd[11] = (byte)(address % 256);//起始地址的低8位
                    cmd[12] = 0x00;
                    break;
                case Type.I:
                    cmd[9] = 0x00;
                    cmd[10] = (byte)(address / 256);//起始地址的高8位
                    cmd[11] = (byte)(address % 256);//起始地址的低8位
                    cmd[12] = 0x00;
                    break;
                case Type.Q:
                    cmd[9] = 0x01;
                    cmd[10] = (byte)(address / 256);//起始地址的高8位
                    cmd[11] = (byte)(address % 256);//起始地址的低8位
                    cmd[12] = 0x00;
                    break;
            }
            cmd[13] = (byte)length;//读取长度
            cmd[14] = 0x05;//字节
            cmd[15] = 0x01;//读数据
            return cmd;
        }

        private byte[] BulidWriteCmd(Type type,int address,byte Value)
        {
            byte[] cmd = new byte[17];
            //报文头
            cmd[0] = 0x03;//客户端
            cmd[1] = 0xFF;//服务端
            cmd[2] = 0x09;//扩展报文头及用户数据总长度
            cmd[3] = (byte)CmdNum++;//
            cmd[4] = 0x00;//响应号
            cmd[5] = 0x00;//错误号
            switch (type)
            {//命令号
                case Type.V:
                    cmd[6] = 0x31;
                    break;
                case Type.M:
                    cmd[6] = 0x33;
                    break;
                case Type.I:
                    cmd[6] = 0x34;
                    break;
                case Type.Q:
                    cmd[6] = 0x34;
                    break;
            }
            cmd[7] = 0x00;//扩展号
            //扩展报文头
            cmd[8] = StationNo;//PLC站号
            switch (type)
            {//地址
                case Type.V:
                    cmd[9] = (byte)(address / 256);//起始地址的高8位
                    cmd[10] = 0x00;//DB号高位
                    cmd[11] = 0x01;//DB号低位
                    cmd[12] = (byte)(address % 256);//起始地址的低8位
                    break;
                case Type.M:
                    cmd[9] = 0x00;
                    cmd[10] = (byte)(address / 256);//起始地址的高8位
                    cmd[11] = (byte)(address % 256);//起始地址的低8位
                    cmd[12] = 0x00;
                    break;
                case Type.I:
                    cmd[9] = 0x00;
                    cmd[10] = (byte)(address / 256);//起始地址的高8位
                    cmd[11] = (byte)(address % 256);//起始地址的低8位
                    cmd[12] = 0x00;
                    break;
                case Type.Q:
                    cmd[9] = 0x01;
                    cmd[10] = (byte)(address / 256);//起始地址的高8位
                    cmd[11] = (byte)(address % 256);//起始地址的低8位
                    cmd[12] = 0x00;
                    break;
            }
            cmd[13] = 0x01;//写入长度
            cmd[14] = 0x05;//字节
            cmd[15] = 0x02;//写数据
            //用户数据
            cmd[16] = Value;
            return cmd;
        }

        public byte StationNo = 0x02;//PLC站号

        private int CmdNum = 0;

        public enum Type
        {//数值无意义，仅作区分
            I = 0x00,
            Q = 0x01,
            M = 0x02,
            V = 0x04
        };

        public enum Size
        {
            bit = 0x01,
            B = 0x02
        };
    }
}
