using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using Gnm.Message;
using Gnm.Utility;

namespace Gnm.IO
{
	internal class GnmSerialTransport : GnmTransport
	{
		private static readonly object _transactionIdLock = new object();
		private ushort _transactionId;

        private int headerIndex = -1;//开头字符
        private int tailIndex = -1;//结束定界符
        private List<byte> instructionData = new List<byte>();

        internal GnmSerialTransport(IStreamResource streamResource)
			: base(streamResource)
		{
            //streamResource.ReadTimeout = 2000;//Do not set this.
            //streamResource.WriteTimeout = 7000;//Do not set this.
            Debug.Assert(streamResource != null, "Argument streamResource cannot be null.");
		}

        internal byte[] ReadRequestResponse(IStreamResource streamResource)
        {
            int count = 0;
            byte[] buffer = new byte[512];
            byte[] data = null;
            int noDataTimes = 0;
            while (true)
            {
                count = streamResource.Read(buffer, 0, 512);

                if (noDataTimes > 16)
                {
                    throw new IOException("Read resulted in 0 bytes returned.");
                }
                if (count == 0)
                {
                    noDataTimes++;
                    System.Threading.Thread.Sleep(10);
                    continue;
                }
                else
                {
                    noDataTimes = 0;
                }

                for(int i = 0; i < count; i++)
                {
                    instructionData.Add(buffer[i]);
                }

                byte cmd = instructionData[0];
                if ((cmd == 0x06) || (cmd == 0x15))
                {
                    data = new byte[] { cmd };
                    instructionData.RemoveAt(0);
                    return data;
                }

                if (headerIndex < 0)
                {
                    for (int i = 0; i < instructionData.Count; i++)
                    {
                        if (instructionData[i] == 0x02)
                        {
                            headerIndex = i;
                            break;
                        }
                    }
                    if (headerIndex < 0)
                    {
                        instructionData.Clear();
                        continue;
                    }
                    if (headerIndex > 0)
                    {
                        instructionData.RemoveRange(0, headerIndex);
                    }
                }

                if (tailIndex < 0)
                {
                    for (int i = 1; i < instructionData.Count; i++)
                    {
                        if (instructionData[i] == 0x03)
                        {
                            tailIndex = i;
                            break;
                        }
                    }
                    if (tailIndex < 0)
                    {
                        if (instructionData.Count > 10240)
                        {
                            instructionData.Clear();
                            headerIndex = -1;
                        }

                        continue;
                    }
                }

                if (tailIndex + 2 + 1 <= instructionData.Count)
                {
                    int checkSum = 0;
                    data = new byte[tailIndex - 1];
                    for(int i = 1; i <= data.Length; i++)
                    {
                        data[i - 1] = instructionData[i];
                        checkSum += instructionData[i];
                    }
                    checkSum += instructionData[tailIndex];
                    byte[] sum = new byte[] { instructionData[tailIndex + 1], instructionData[tailIndex + 2] };

                    headerIndex = -1;
                    tailIndex = -1;

                    instructionData.RemoveRange(0, data.Length + 4);

                    string checkSumStr = checkSum.ToString("X2");
                    if ((sum[0] != (byte)checkSumStr[checkSumStr.Length - 2])
                        || (sum[1] != (byte)checkSumStr[checkSumStr.Length - 1]))
                        throw new IOException("Checksum Error.");

                    data = GnmUtility.HexToBytes(data);
                    return data;
                }
                else continue;
            }
        }

		/// <summary>
		/// Create a new transaction ID.
		/// </summary>
		internal virtual ushort GetNewTransactionId()
		{
			lock (_transactionIdLock)
				_transactionId = _transactionId == UInt16.MaxValue ? (ushort) 1 : ++_transactionId;

			return _transactionId;
		}

        internal override byte[] BuildMessageFrame(IGnmMessage message)
		{
            return message.ProtocolDataUnit;
		}

		internal override void Write(IGnmMessage message)
		{
            message.TransactionId = GetNewTransactionId();
			byte[] frame = BuildMessageFrame(message);
			StreamResource.Write(frame, 0, frame.Length);
		}	

		internal override byte[] ReadRequest()
		{
			return ReadRequestResponse(StreamResource);
		}

		internal override IGnmMessage ReadResponse<T>()
		{
            return base.CreateResponse<T>(ReadRequestResponse(StreamResource));
		}

        internal override void OnValidateResponse(IGnmMessage request, IGnmMessage response)
        {
            //if (request.TransactionId != response.TransactionId)
            //    throw new IOException(String.Format(CultureInfo.InvariantCulture, "Response was not of expected transaction ID. Expected {0}, received {1}.", request.TransactionId, response.TransactionId));
        }
    }
}
