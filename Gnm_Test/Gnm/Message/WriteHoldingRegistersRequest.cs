using System;
using System.Globalization;
using System.IO;
using System.Net;
using Gnm.Data;
using Gnm.Utility;

namespace Gnm.Message
{
	class WriteHoldingRegistersRequest : GnmMessageWithData<RegisterCollection>, IGnmRequest
	{
		public WriteHoldingRegistersRequest()
		{
		}

		public WriteHoldingRegistersRequest(byte slaveAddress, ushort startAddress, RegisterCollection data)
			: base(slaveAddress, Gnm.WriteMultipleRegisters)
		{
			StartAddress = startAddress;
			NumberOfPoints = (ushort)data.Count;
			ByteCount = (byte) (data.Count * 2);
			Data = data;
		}

        byte[] commandBody = new byte[8];
        internal override void Init()
        {
            commandBody[0] = 0x02;//STX
            commandBody[1] = 0x31;//Device Write Command
        }

        internal override void BeforeMakeProtocalDataUnit()
        {
            byte[] bs = GnmUtility.GetAsciiBytes((ushort)(StartAddress * 2 + 0x1000));
            commandBody[2] = bs[0];
            commandBody[3] = bs[1];
            commandBody[4] = bs[2];
            commandBody[5] = bs[3];

            bs = GnmUtility.GetAsciiBytes((byte)(NumberOfPoints * 2));
            commandBody[6] = bs[0];
            commandBody[7] = bs[1];

            CommandData = new byte[11 + Data.Count * 4];
            Array.Copy(commandBody, CommandData, 8);
            CommandData[CommandData.Length - 3] = 3;//ETX

            for (int i = 0; i < Data.Count; i++)
            {
                bs = GnmUtility.GetAsciiBytes(Data[i]);
                CommandData[i * 4 + 8] = bs[2];
                CommandData[i * 4 + 8 + 1] = bs[3];
                CommandData[i * 4 + 8 + 2] = bs[0];
                CommandData[i * 4 + 8 + 3] = bs[1];
            }

            ushort sum = 0;
            for (int i = 1; i < CommandData.Length - 2; i++)
            {
                sum += CommandData[i];
            }

            string sumStr = sum.ToString("X2");

            CommandData[CommandData.Length - 2] = (byte)sumStr[sumStr.Length - 2];
            CommandData[CommandData.Length - 1] = (byte)sumStr[sumStr.Length - 1];
        }

        public void ValidateResponse(IGnmMessage response)
        {

        }

		protected override void InitializeUnique(byte[] frame)
		{

        }

        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "Write {0} holding registers starting at address {1}.", NumberOfPoints, StartAddress);
        }
    }
}
