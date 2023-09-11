using ElonMusk.View;
using System;
using System.Drawing;

namespace ElonMusk.Model
{
	/// <summary>
	/// Class <c>CarRomteControlled</c> is a model for remote controlled cars, also known as RC-cars.
	/// </summary>
	public class CarRC
	{
		private int _carIdentity;
		private Color _carColor;

		public int CarIdentity
		{
			get { return _carIdentity; }
			set { _carIdentity = value; }
		}
		public Color CarColor
		{
			get { return _carColor; }
			set { _carColor = value; }
		}

		public void ColorSelection()
		{
			while (true)
			{
				var selectIn = Console.ReadKey(true).Key;

				switch (selectIn)
				{
					case ConsoleKey.D1:
						_carColor = Color.MediumVioletRed;
						return;

					case ConsoleKey.D2:
						_carColor = Color.AliceBlue;
						return;
					case ConsoleKey.D3:
						_carColor = Color.GhostWhite;
						return;
				}
			}
		}
		public void Activate()
		{
			CarBattery battery = new CarBattery();
			CarGUI carGUI = new CarGUI();

			if (battery.BatteryLevel != 0)
			{
				for (int metersDriven = 0; metersDriven < battery.BatteryLevel; metersDriven++)
				{
					byte currBattery = (byte)(battery.BatteryLevel - battery.BatteryDrain);
					//int currDist = metersDriven;
				}
			}
			else
			{
				carGUI.BatteryEmpty();
			}
		}
	}
}

