using System;
using System.Globalization;
using System.IO;
using System.Net;
using Gnm.Utility;

namespace Gnm.Message
{
	class ReadCoilsRequest : GnmMessage, IGnmRequest
	{
		private const int _minimumFrameSize = 6;

		public ReadCoilsRequest()
		{
		}

		public ReadCoilsRequest(byte functionCode, byte slaveAddress, ushort startAddress, ushort numberOfPoints)
			: base(slaveAddress, functionCode)
		{
			StartAddress = startAddress;
			NumberOfPoints = numberOfPoints;
		}

        byte[] commandBody = new byte[11];
        internal override void Init()
        {
            commandBody[0] = 0x02;//STX
            commandBody[1] = 0x30;//Device Read Command
            commandBody[8] = 0x03;//ETX
        }

        internal override void BeforeMakeProtocalDataUnit()
        {
            byte[] bs = GnmUtility.AnalysisAddress(FunctionCode, StartAddress);//GnmUtility.GetAsciiBytes((ushort)((StartAddress / 16) * 2 + 0x100));//MÇøµØÖ·
            commandBody[2] = bs[0];
            commandBody[3] = bs[1];
            commandBody[4] = bs[2];
            commandBody[5] = bs[3];

            byte byteCount = (byte)(((StartAddress + NumberOfPoints) / 16 + 1) * 2 - (StartAddress / 16) * 2);
            bs = GnmUtility.GetAsciiBytes(byteCount);
            commandBody[6] = bs[0];
            commandBody[7] = bs[1];

            ushort sum = 0;
            for (int i = 1; i < 9; i++)
            {
                sum += commandBody[i];
            }
            string sumStr = sum.ToString("X2");

            commandBody[9] = (byte)sumStr[sumStr.Length - 2];
            commandBody[10] = (byte)sumStr[sumStr.Length - 1];
            CommandData = commandBody;
        }

        public void ValidateResponse(IGnmMessage response)
        {

        }

		protected override void InitializeUnique(byte[] frame)
		{

        }        
    }
}
