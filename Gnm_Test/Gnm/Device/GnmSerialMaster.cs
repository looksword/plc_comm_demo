using System;
using System.Diagnostics.CodeAnalysis;
//using System.IO.Ports;
using System.Net.Sockets;
using Gnm.IO;

namespace Gnm.Device
{
	/// <summary>
	/// Gnm IP master device.
	/// </summary>
	[SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", Justification = "Breaking change.")]
	public class GnmSerialMaster : GnmMaster
	{
        private GnmSerialMaster(GnmTransport transport)
			: base(transport)
		{
		}

		/// <summary>
		/// Gnm IP master factory method.
		/// </summary>
		[SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", Justification = "Breaking change.")]
        public static GnmSerialMaster Create(SerialPort serialPort)
		{
			if (serialPort == null)
				throw new ArgumentNullException("serialPort");

            return new GnmSerialMaster(new GnmSerialTransport(new SerialPortAdapter(serialPort)));
		}

        /// <summary>
        /// Gnm IP master factory method.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", Justification = "Breaking change.")]
        public static GnmSerialMaster Create(UdpClient udpClient)
        {
            if (udpClient == null)
                throw new ArgumentNullException("udpClient");
            if (!udpClient.Client.Connected)
                throw new InvalidOperationException(Resources.UdpClientNotConnected);

            return new GnmSerialMaster(new GnmSerialTransport(new UdpClientAdapter(udpClient)));
        }

        /// <summary>
        /// Gnm IP master factory method.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase", Justification = "Breaking change.")]
        public static GnmSerialMaster Create(TcpClient tcpClient)
        {
            if (tcpClient == null)
                throw new ArgumentNullException("tcpClient");

            return new GnmSerialMaster(new GnmSerialTransport(new TcpClientAdapter(tcpClient)));
        }

        /// <summary>
		/// Read from 1 to 2000 contiguous coils status.
		/// </summary>
		/// <param name="startAddress">Address to begin reading.</param>
		/// <param name="numberOfPoints">Number of coils to read.</param>
		/// <returns>Coils status</returns>
		public bool[] ReadCoils(ushort startAddress, ushort numberOfPoints)
		{
			return base.ReadCoils(Gnm.DefaultIpSlaveUnitId, startAddress, numberOfPoints);
		}

		/// <summary>
		/// Read from 1 to 2000 contiguous discrete input status.
		/// </summary>
		/// <param name="startAddress">Address to begin reading.</param>
		/// <param name="numberOfPoints">Number of discrete inputs to read.</param>
		/// <returns>Discrete inputs status</returns>
		public bool[] ReadInputs(ushort startAddress, ushort numberOfPoints)
		{
			return base.ReadInputs(Gnm.DefaultIpSlaveUnitId, startAddress, numberOfPoints);
		}

		/// <summary>
		/// Read contiguous block of holding registers.
		/// </summary>
		/// <param name="startAddress">Address to begin reading.</param>
		/// <param name="numberOfPoints">Number of holding registers to read.</param>
		/// <returns>Holding registers status</returns>
		public ushort[] ReadHoldingRegisters(ushort startAddress, ushort numberOfPoints)
		{
			return base.ReadHoldingRegisters(Gnm.DefaultIpSlaveUnitId, startAddress, numberOfPoints);
		}

		/// <summary>
		/// Read contiguous block of input registers.
		/// </summary>
		/// <param name="startAddress">Address to begin reading.</param>
		/// <param name="numberOfPoints">Number of holding registers to read.</param>
		/// <returns>Input registers status</returns>
		public ushort[] ReadInputRegisters(ushort startAddress, ushort numberOfPoints)
		{
			return base.ReadInputRegisters(Gnm.DefaultIpSlaveUnitId, startAddress, numberOfPoints);
		}

		/// <summary>
		/// Write a single coil value.
		/// </summary>
		/// <param name="coilAddress">Address to write value to.</param>
		/// <param name="value">Value to write.</param>
		public void WriteSingleCoil(ushort coilAddress, bool value)
		{
			base.WriteSingleCoil(Gnm.DefaultIpSlaveUnitId, coilAddress, value);
		}

		/// <summary>
		/// Write a single holding register.
		/// </summary>
		/// <param name="registerAddress">Value to write.</param>
		/// <param name="value">Value to write.</param>
		public void WriteSingleRegister(ushort registerAddress, ushort value)
		{
			base.WriteSingleRegister(Gnm.DefaultIpSlaveUnitId, registerAddress, value);
		}

		/// <summary>
		/// Write a block of 1 to 123 contiguous registers.
		/// </summary>
		/// <param name="startAddress">Address to begin writing values.</param>
		/// <param name="data">Values to write.</param>
		public void WriteHoldingRegisters(ushort startAddress, ushort[] data)
		{
			base.WriteHoldingRegisters(Gnm.DefaultIpSlaveUnitId, startAddress, data);
		}

		/// <summary>
		/// Force each coil in a sequence of coils to a provided value.
		/// </summary>
		/// <param name="startAddress">Address to begin writing values.</param>
		/// <param name="data">Values to write.</param>
		public void WriteCoils(ushort startAddress, bool[] data)
		{
			base.WriteCoils(Gnm.DefaultIpSlaveUnitId, startAddress, data);
		}
	}
}
