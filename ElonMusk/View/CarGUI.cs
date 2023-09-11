using ElonMusk.Model;
using System;


namespace ElonMusk.View
{
	/// <summary>
	/// Class <c>CarGUI</c> contains all the output to the console.
	/// </summary>
	internal class CarGUI
	{
		public void Intro()
		{
			Console.WriteLine("Welcome to Elon Musk's (not actually affiliated with Elon Musk) RC Car project!\n" +
				"Here you can create a car and give it a color, then give it a run using your very own imagination! Wow!\n" +
				"Please create two cars!\n");
		}
		public void BatteryFull()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("The battery is fully recharged! Let's get this show on the road!");
			Console.ResetColor();
		}
		public void BatteryLow()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("The battery is low! Please charge or replace the battery!");
			Console.ResetColor();
		}
		public void BatteryEmpty()
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("The battery is empty! You have to charge or replace the battery!");
			Console.ResetColor();
		}
		public void CarA()
		{
			Console.WriteLine("This is car number 1!\n");
		}
		public void CarB()
		{
			Console.WriteLine("This is car number 2!\n");
		}
		public void CarColor()
		{
			Console.WriteLine("Please pick a color!\n1 = Red\n2 = Blue\n3 = White\n");
		}
		public void CarSelection()
		{
			Console.WriteLine("Please pick a car:\n" +
				"1 = Car no. 1\n2 = Car no. 2\n");
		}
		public void CarStatus(CarDisplay display, CarBattery battery) 
		{
            Console.WriteLine($"Distance driven = {display.DisplayDistance}.\nBattery = {battery.BatteryLevel}%");
        }

		internal void CarStatus(CarRC carRC)
		{
			throw new NotImplementedException();
		}
	}
}
