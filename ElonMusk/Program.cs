using ElonMusk.Controller;
using System;
using System.Drawing;

namespace ElonMusk
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			const ushort MAX_BATTERY = 100;
			ushort battery;
			byte drainRate = 20; // 1% per meter
			int distance;

			distance = 1320;

			for (int i = 0; i <= distance; i++)
			{
				if ((i % drainRate) == 0)
				Console.WriteLine(i);
			}
			*/
			CarController carCtrl = new CarController();
			carCtrl.Start();
		}
	}
}
