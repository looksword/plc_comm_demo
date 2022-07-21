using System;
using System.Globalization;
using System.Net;

namespace Gnm.Message
{
	class WriteHoldingRegistersResponse : GnmMessage, IGnmMessage
	{
		public WriteHoldingRegistersResponse()
		{
		}

		public WriteHoldingRegistersResponse(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
			: base(slaveAddress, Gnm.WriteMultipleRegisters)
		{
			StartAddress = startAddress;
			NumberOfPoints = numberOfPoints;
		}

		protected override void InitializeUnique(byte[] frame)
		{
            if (frame[0] == 0x15)
                throw new Exception("NAK");
		}

        public override string ToString()
        {
            return String.Format(CultureInfo.InvariantCulture, "Wrote {0} holding registers starting at address {1}.", NumberOfPoints, StartAddress);
        }
    }
}
