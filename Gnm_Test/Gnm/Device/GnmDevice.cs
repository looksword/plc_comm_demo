using System;
using Gnm.IO;

namespace Gnm.Device
{
	/// <summary>
	/// Gnm device.
	/// </summary>
	public abstract class GnmDevice : IDisposable
	{
		private GnmTransport _transport;

		internal GnmDevice(GnmTransport transport)
		{
			_transport = transport;
		}

		/// <summary>
		/// Gets the Gnm Transport.
		/// </summary>
		/// <value>The transport.</value>
		public GnmTransport Transport
		{
			get 
			{ 
				return _transport; 
			}
		}

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_transport != null)
                {
                    _transport.Dispose();
                    _transport = null;
                }
            }
        }
	}
}
