using System;

namespace ElonMusk.Model
{
	public class CarBattery
	{

		private byte _batteryLevel = BATTERY_CAPACITY;
		private byte _batteryDrain = BATTERY_SUBTRACT;
		private const byte BATTERY_CAPACITY = 100;
		private const byte BATTERY_SUBTRACT = 1;

		public byte BatteryLevel
		{
			get { return _batteryLevel; }
			set { _batteryLevel = value; }
		}
		public byte BatteryDrain
		{
			get { return _batteryDrain; }
			set { _batteryDrain = value; }
		}
	}
}
