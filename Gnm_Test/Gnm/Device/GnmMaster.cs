using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using Gnm.Data;
using Gnm.IO;
using Gnm.Message;
using Gnm.Utility;

namespace Gnm.Device
{
	/// <summary>
	/// Gnm master device.
	/// </summary>
	public abstract class GnmMaster : GnmDevice
	{
		internal GnmMaster(GnmTransport transport)
			: base(transport)
		{
		}

		/// <summary>
		/// Read from 1 to 2000 contiguous coils status.
		/// </summary>
		/// <param name="slaveAddress">Address of device to read values from.</param>
		/// <param name="startAddress">Address to begin reading.</param>
		/// <param name="numberOfPoints">Number of coils to read.</param>
		/// <returns>Coils status</returns>
		public bool[] ReadCoils(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
		{
			ValidateNumberOfPoints("numberOfPoints", numberOfPoints, 2000);

			return ReadDiscretes(Gnm.ReadCoils, slaveAddress, startAddress, numberOfPoints);
		}

        public bool[] ReadXareas(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            ValidateNumberOfPoints("numberOfPoints", numberOfPoints, 200);

            return ReadDiscretes(Gnm.ReadXarea, slaveAddress, startAddress, numberOfPoints);
        }

        public bool[] ReadYareas(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            ValidateNumberOfPoints("numberOfPoints", numberOfPoints, 200);

            return ReadDiscretes(Gnm.ReadYarea, slaveAddress, startAddress, numberOfPoints);
        }

		/// <summary>
		/// Read from 1 to 2000 contiguous discrete input status.
		/// </summary>
		/// <param name="slaveAddress">Address of device to read values from.</param>
		/// <param name="startAddress">Address to begin reading.</param>
		/// <param name="numberOfPoints">Number of discrete inputs to read.</param>
		/// <returns>Discrete inputs status</returns>
		public bool[] ReadInputs(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
		{
			ValidateNumberOfPoints("numberOfPoints", numberOfPoints, 2000);

			return ReadDiscretes(Gnm.ReadInputs, slaveAddress, startAddress, numberOfPoints);
		}		

		/// <summary>
		/// Read contiguous block of holding registers.
		/// </summary>
		/// <param name="slaveAddress">Address of device to read values from.</param>
		/// <param name="startAddress">Address to begin reading.</param>
		/// <param name="numberOfPoints">Number of holding registers to read.</param>
		/// <returns>Holding registers status</returns>
		public ushort[] ReadHoldingRegisters(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
		{
			ValidateNumberOfPoints("numberOfPoints", numberOfPoints, 125);

			return ReadRegisters(Gnm.ReadHoldingRegisters, slaveAddress, startAddress, numberOfPoints);
		}

		/// <summary>
		/// Read contiguous block of input registers.
		/// </summary>
		/// <param name="slaveAddress">Address of device to read values from.</param>
		/// <param name="startAddress">Address to begin reading.</param>
		/// <param name="numberOfPoints">Number of holding registers to read.</param>
		/// <returns>Input registers status</returns>
		public ushort[] ReadInputRegisters(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
		{
			ValidateNumberOfPoints("numberOfPoints", numberOfPoints, 125);

			return ReadRegisters(Gnm.ReadInputRegisters, slaveAddress, startAddress, numberOfPoints);
		}

		/// <summary>
		/// Write a single coil value.
		/// </summary>
		/// <param name="slaveAddress">Address of the device to write to.</param>
		/// <param name="coilAddress">Address to write value to.</param>
		/// <param name="value">Value to write.</param>
		public void WriteSingleCoil(byte slaveAddress, ushort coilAddress, bool value)
		{
            WriteCoils(slaveAddress, coilAddress, new bool[] { value });
        }

		/// <summary>
		/// Write a single holding register.
		/// </summary>
		/// <param name="slaveAddress">Address of the device to write to.</param>
		/// <param name="registerAddress">Value to write.</param>
		/// <param name="value">Value to write.</param>
		public void WriteSingleRegister(byte slaveAddress, ushort registerAddress, ushort value)
		{
            WriteHoldingRegisters(slaveAddress, registerAddress, new ushort[] { value });
        }

		/// <summary>
		/// Write a block of 1 to 123 contiguous registers.
		/// </summary>
		/// <param name="slaveAddress">Address of the device to write to.</param>
		/// <param name="startAddress">Address to begin writing values.</param>
		/// <param name="data">Values to write.</param>
		public void WriteHoldingRegisters(byte slaveAddress, ushort startAddress, ushort[] data)
		{
			//ValidateData("data", data, 123);

			WriteHoldingRegistersRequest request = new WriteHoldingRegistersRequest(slaveAddress, startAddress, new RegisterCollection(data));
			Transport.UnicastMessage<WriteHoldingRegistersResponse>(request);
		}	

		/// <summary>
		/// Force each coil in a sequence of coils to a provided value.
		/// </summary>
		/// <param name="slaveAddress">Address of the device to write to.</param>
		/// <param name="startAddress">Address to begin writing values.</param>
		/// <param name="data">Values to write.</param>
		public void WriteCoils(byte slaveAddress, ushort startAddress, bool[] data)
		{
			//ValidateData("data", data, 1968);

            for (int i = 0; i < data.Length; i++)
            {
                WriteCoilRequest request = new WriteCoilRequest(slaveAddress, (ushort)(startAddress + i), new DiscreteCollection(data[i]));
                Transport.UnicastMessage<WriteCoilResponse>(request);
            }
		}

		/// <summary>
		/// Executes the custom message.
		/// </summary>
		/// <typeparam name="TResponse">The type of the response.</typeparam>
		/// <param name="request">The request.</param>
		[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
		[SuppressMessage("Microsoft.Usage", "CA2223:MembersShouldDifferByMoreThanReturnType")]
		public TResponse ExecuteCustomMessage<TResponse>(IGnmMessage request) where TResponse : IGnmMessage, new()
		{
			return Transport.UnicastMessage<TResponse>(request);
		}

		internal static void ValidateData<T>(string argumentName, T[] data, int maxDataLength)
		{
			if (data == null)
				throw new ArgumentNullException("data");

			if (data.Length == 0 || data.Length > maxDataLength)
			{
				throw new ArgumentException(String.Format(CultureInfo.InvariantCulture,
					"The length of argument {0} must be between 1 and {1} inclusive.", argumentName, maxDataLength));
			}
		}

		internal static void ValidateNumberOfPoints(string argumentName, ushort numberOfPoints, ushort maxNumberOfPoints)
		{
			if (numberOfPoints < 1 || numberOfPoints > maxNumberOfPoints)
			{
				throw new ArgumentException(String.Format(CultureInfo.InvariantCulture,
					"Argument {0} must be between 1 and {1} inclusive.", argumentName, maxNumberOfPoints));
			}
		}

		internal ushort[] ReadRegisters(byte functionCode, byte slaveAddress, ushort startAddress, ushort numberOfPoints)
		{
			ReadHoldingRegistersRequest request = new ReadHoldingRegistersRequest(functionCode, slaveAddress, startAddress, numberOfPoints);
			ReadHoldingRegistersResponse response = Transport.UnicastMessage<ReadHoldingRegistersResponse>(request);

			return CollectionUtility.ToArray(response.Data);
		}

		internal bool[] ReadDiscretes(byte functionCode, byte slaveAddress, ushort startAddress, ushort numberOfPoints)
		{
			ReadCoilsRequest request = new ReadCoilsRequest(functionCode, slaveAddress, startAddress, numberOfPoints);
			ReadCoilsResponse response = Transport.UnicastMessage<ReadCoilsResponse>(request);
            int offset = startAddress % 8;

			return CollectionUtility.Slice(response.Data, offset, request.NumberOfPoints);
		}
	}
}
