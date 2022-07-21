using System;
using System.Globalization;
using System.IO;
using System.Net;
using Gnm.Data;
using Gnm.Utility;

namespace Gnm.Message
{
	class WriteCoilRequest : GnmMessageWithData<DiscreteCollection>, IGnmRequest
	{
		public WriteCoilRequest()
		{
		}

		public WriteCoilRequest(byte slaveAddress, ushort startAddress, DiscreteCollection data)
			: base(slaveAddress, Gnm.WriteMultipleCoils)
		{
			StartAddress = startAddress;
			NumberOfPoints = (ushort) data.Count;
			ByteCount = (byte) ((data.Count + 7) / 8);
			Data = data;
		}

        byte[] commandBody = new byte[9];
        internal override void Init()
        {
            commandBody[0] = 0x02;//STX
            commandBody[1] = 0x37;//Force ON Command
            commandBody[6] = 0x03;//ETX
        }

        internal override void BeforeMakeProtocalDataUnit()
        {
            if (!Data[0])
                commandBody[1] = 0x38;//Force OFF Command

            byte[] bs = GnmUtility.GetAsciiBytes((ushort)(StartAddress + 0x800));//MÇøµØÖ·:0x0800 - 0x0BFF£¨M0 - M1023£©
            commandBody[2] = bs[2];
            commandBody[3] = bs[3];
            commandBody[4] = bs[0];
            commandBody[5] = bs[1];

            ushort sum = 0;
            for (int i = 1; i < 7; i++)
            {
                sum += commandBody[i];
            }
            string sumStr = sum.ToString("X2");

            commandBody[7] = (byte)sumStr[sumStr.Length - 2];
            commandBody[8] = (byte)sumStr[sumStr.Length - 1];
            CommandData = commandBody;
        }

        public void ValidateResponse(IGnmMessage response)
        {

        }

		protected override void InitializeUnique(byte[] frame)
		{

        }

        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "Write {0} coils starting at address {1}.", NumberOfPoints, StartAddress);
        }
    }
}
