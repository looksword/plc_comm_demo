using System;
using System.Globalization;
using Gnm.Data;
using Gnm.Utility;

namespace Gnm.Message
{	
	class ReadCoilsResponse : GnmMessageWithData<DiscreteCollection>, IGnmMessage
	{
		private const int _minimumFrameSize = 3;

		public ReadCoilsResponse()
		{
		}

		public ReadCoilsResponse(byte functionCode, byte slaveAddress, byte byteCount, DiscreteCollection data)
			: base(slaveAddress, functionCode)
		{
            if (data == null)
                throw new ArgumentNullException("data");

            ByteCount = byteCount;
			Data = data;
		}

        protected override void InitializeUnique(byte[] data)
		{
            if (data == null) return;
            if (data.Length == 0) return;
            bool[] bs = new bool[data.Length * 8];
            for (int i = 0; i < data.Length / 2; i++)
            {
                int j = i * 16, k = i * 2;
                bs[j + 0] = (data[k] & 1) > 0;
                bs[j + 1] = (data[k] & 2) > 0;
                bs[j + 2] = (data[k] & 4) > 0;
                bs[j + 3] = (data[k] & 8) > 0;
                bs[j + 4] = (data[k] & 16) > 0;
                bs[j + 5] = (data[k] & 32) > 0;
                bs[j + 6] = (data[k] & 64) > 0;
                bs[j + 7] = (data[k] & 128) > 0;

                k++;
                bs[j + 8] = (data[k] & 1) > 0;
                bs[j + 9] = (data[k] & 2) > 0;
                bs[j + 10] = (data[k] & 4) > 0;
                bs[j + 11] = (data[k] & 8) > 0;
                bs[j + 12] = (data[k] & 16) > 0;
                bs[j + 13] = (data[k] & 32) > 0;
                bs[j + 14] = (data[k] & 64) > 0;
                bs[j + 15] = (data[k] & 128) > 0;
            }

            Data = new DiscreteCollection(bs);
		}
	}
}
