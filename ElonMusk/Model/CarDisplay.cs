using System;

namespace ElonMusk.Model
{
	public class CarDisplay
	{
		private int _displayDistance;
		private byte _displayBattery;

		public int DisplayDistance
		{
			get { return _displayDistance; }
			set { _displayDistance = value; }
		}
		public byte DisplayBattery
		{
			get { return _displayBattery; }
			set { _displayBattery = value; }
		}
	}
}
