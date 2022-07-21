using Gnm.Data;

namespace Gnm.Message
{
	abstract class GnmMessageWithData<TData> : GnmMessage where TData : IGnmMessageDataCollection
	{
		public GnmMessageWithData()
		{
		}

		public GnmMessageWithData(byte slaveAddress, byte functionCode)
			: base(slaveAddress, functionCode)
		{
		}

        public new TData Data { get; set; }
	}
}
