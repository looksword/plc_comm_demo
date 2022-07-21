using System;
using System.Globalization;
using Gnm.Data;
using Gnm.Utility;

namespace Gnm.Message
{
	class ReadHoldingRegistersResponse : GnmMessageWithData<RegisterCollection>, IGnmMessage
	{
		public ReadHoldingRegistersResponse()
		{
		}

		public ReadHoldingRegistersResponse(byte functionCode, byte slaveAddress, RegisterCollection data)
			: base(slaveAddress, functionCode)
		{
			if (data == null)
				throw new ArgumentNullException("data");

			ByteCount = data.ByteCount;
			Data = data;
		}

		protected override void InitializeUnique(byte[] data)
		{
            if (data == null) return;
            if (data.Length % 2 != 0)
                throw new FormatException(Resources.NetworkBytesNotEven);
            ushort[] us = new ushort[data.Length / 2];
            for (int i = 0; i < us.Length; i++)
            {
                us[i] = (ushort)(data[i * 2 + 1] * 256 + data[i * 2]);
            }

            Data = new RegisterCollection(us);
        }
	}
}
