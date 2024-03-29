using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading;

namespace Gnm.IO
{
	/// <summary>
	/// Concrete Implementor - http://en.wikipedia.org/wiki/Bridge_Pattern
	/// </summary>
	internal class TcpClientAdapter : IStreamResource
	{
		private TcpClient _tcpClient;

		public TcpClientAdapter(TcpClient tcpClient)
		{
			Debug.Assert(tcpClient != null, "Argument tcpClient cannot be null.");

			_tcpClient = tcpClient;
		}

		public int InfiniteTimeout
		{
			get { return Timeout.Infinite; }
		}

		public int ReadTimeout
		{
			get { return _tcpClient.GetStream().ReadTimeout; }
			set { _tcpClient.GetStream().ReadTimeout = value; }
		}

		public int WriteTimeout
		{
			get { return _tcpClient.GetStream().WriteTimeout; }
			set { _tcpClient.GetStream().WriteTimeout = value; }
		}

		public void Write(byte[] buffer, int offset, int size)
		{
			_tcpClient.GetStream().Write(buffer, offset, size);
		}

		public int Read(byte[] buffer, int offset, int size)
		{
			return _tcpClient.GetStream().Read(buffer, offset, size);
		}

		public void DiscardInBuffer()
		{
			_tcpClient.GetStream().Flush();
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (_tcpClient != null)
				{
					_tcpClient.Close();
					_tcpClient = null;
				}
			}
		}
	}
}
