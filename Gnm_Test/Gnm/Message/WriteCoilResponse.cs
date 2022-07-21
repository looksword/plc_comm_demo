using System;
using System.Globalization;
using System.Net;

namespace Gnm.Message
{
	class WriteCoilResponse : GnmMessage, IGnmMessage
	{
		private const int _minimumFrameSize = 6;

		public WriteCoilResponse()
		{
		}

		public WriteCoilResponse(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
			: base(slaveAddress, Gnm.WriteMultipleCoils)
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
            return String.Format(CultureInfo.InvariantCulture, "Wrote {0} coils starting at address {1}.", NumberOfPoints, StartAddress);
        }
    }
}
