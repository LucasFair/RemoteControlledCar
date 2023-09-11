using ElonMusk.Model;
using ElonMusk.View;
using System;


namespace ElonMusk.Controller
{
	/// <summary>
	/// Class <c>CarController</c> is what controls the program by calling to the view and model.
	/// </summary>
	public class CarController
	{
		public void Start()
		{
			CarGUI carGUI = new CarGUI();

			carGUI.Intro();
			carGUI.CarA();
			CarRC carA = CreateCar();
			carGUI.CarB();
			CarRC carB = CreateCar();
			carGUI.CarSelection();
			CarSelection(carA, carB);
		}

		public void CarSelection(CarRC carA, CarRC carB)
		{
			while (true)
			{
				var selectIn = Console.ReadKey(true).Key;

				switch (selectIn)
				{
					case ConsoleKey.D1:
						Drive(carA);
						break;
					case ConsoleKey.D2:
						Drive(carB);
						break;

					default:
						break;
				}
			}
		}
		public CarRC CreateCar()
		{
			CarGUI carGUI = new CarGUI();
			CarRC carRC = new CarRC();

			carGUI.CarColor();
			carRC.ColorSelection();

			return carRC;
		}
		public void Recharge()
		{
			CarBattery battery = new CarBattery();

			battery.BatteryLevel = 100;
		}

		public void Drive(CarRC carRC)
		{
			CarGUI carGUI = new CarGUI();

			while (true)
			{
				//carGUI.CarStatus(carRC);
				var selectIn = Console.ReadKey(true).Key;
				switch (selectIn)
				{
					case ConsoleKey.D1:
						carRC.Activate();
						break;

					case ConsoleKey.D2:
						Recharge();
						break;

					default:
						break;
				}
			}
		}
	}
}