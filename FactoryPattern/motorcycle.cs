using System;
namespace FactoryPattern
{
	public class motorcycle : IVehicle
	{
		public motorcycle()
		{
		}

		public void Drive()
		{
			Console.WriteLine("moto is revving up");
			Console.WriteLine("woo");
		}
	}
}

