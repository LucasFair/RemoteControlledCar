using ElonMusk.View;
using System;
using System.Drawing;
using System.Threading;

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
			CarDisplay display = new CarDisplay();
			CarGUI carGUI = new CarGUI();

			display.DisplayDistance = 100;
			battery.BatteryLevel = 20;


			for (int i = 0; i < display.DisplayDistance; i++)
			{
				if (i % battery.BatteryDrain == 0)
				{
					battery.BatteryLevel -= 1;
					if (battery.BatteryLevel > 0)
					{
						Console.WriteLine(battery.BatteryLevel);
						Thread.Sleep(600);  // Adds a delay by halting the process of the thread for a given time
					}
				}
				else
				{
					carGUI.BatteryEmpty();
				}
			}
		}
	}
}
