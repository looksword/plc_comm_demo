using System;
using System.Collections.Generic;
using System.Globalization;
using Gnm.Data;
using Gnm.Utility;

namespace Gnm.Message
{
	abstract class GnmMessage
	{
        public GnmMessage()
        {
            Init();
        }

		public GnmMessage(byte slaveAddress, byte functionCode)
		{
            FunctionCode = functionCode;
            Init();
		}

        public static T CreateGnmMessage<T>(byte[] frame) where T : IGnmMessage, new()
        {
            IGnmMessage message = new T();
            message.Initialize(frame);

            return (T)message;
        }

        internal virtual void Init()
        {

        }

        public byte SlaveAddress { get; set; }

        internal byte[] CommandData { get; set; }

        public virtual byte FunctionCode { get; set; }

        public virtual ushort NumberOfPoints { get; set; }

        public virtual ushort StartAddress { get; set; }

        public byte ByteCount { get; set; }

        public byte? ExceptionCode { get; set; }

		public ushort TransactionId { get; set; }
		
		public IGnmMessageDataCollection Data { get; set; }

		public virtual byte[] ProtocolDataUnit
		{
			get
			{
                BeforeMakeProtocalDataUnit();

                return CommandData;
			}
		}

        internal virtual void BeforeMakeProtocalDataUnit()
        {

        }

		public void Initialize(byte[] frame)
		{
            if (frame == null)
                throw new ArgumentNullException("frame", "Argument frame cannot be null.");

            InitializeUnique(frame);
		}
     
		protected abstract void InitializeUnique(byte[] data);

	}
}
