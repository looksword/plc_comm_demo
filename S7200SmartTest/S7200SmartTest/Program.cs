using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication.Siemens;
using HslCommunication;

namespace S7200SmartTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SiemensS7Net test = new SiemensS7Net(SiemensS7Net.SiemensPLCS.S200Smart, "10.1.45.237");
            OperateResult connect = test.ConnectServer();
            if (connect.IsSuccess)
            {
                OperateResult<byte[]> result = test.Read("V100",2);
                if (result.IsSuccess)
                {
                    Console.Write(result.Content[0].ToString());
                    Console.Write(",");
                    Console.Write(result.Content[1].ToString());
                    Console.Write(Environment.NewLine);
                }
                else
                {
                    Console.Write("GG1");
                    Console.Write(Environment.NewLine);
                }

                OperateResult Result = test.Write("V100", new byte[] { 0, 0,0,0 });
                if(!Result.IsSuccess)
                {
                    Console.Write("GG2");
                    Console.Write(Environment.NewLine);
                }

                result = test.Read("V100", 2);
                if (result.IsSuccess)
                {
                    Console.Write(result.Content[0].ToString());
                    Console.Write(",");
                    Console.Write(result.Content[1].ToString());
                    Console.Write(Environment.NewLine);
                }
                else
                {
                    Console.Write("GG3");
                    Console.Write(Environment.NewLine);
                }

                test.ConnectClose();
            }

            Console.ReadKey();
        }
    }
}
