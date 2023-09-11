using ElonMusk.Controller;
using System;
using System.Threading;

namespace ElonMusk
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CarController carCtrl = new CarController();
			carCtrl.Start();
		}
	}
}
