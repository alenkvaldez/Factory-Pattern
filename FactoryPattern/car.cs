using System;
namespace FactoryPattern
{
	public class car : IVehicle
	{
		public car()
		{
		}

		public void Drive()
		{
			Console.WriteLine("the car is driving! woo");
		}
	}
}

