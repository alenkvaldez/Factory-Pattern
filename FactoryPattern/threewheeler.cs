using System;
namespace FactoryPattern
{
	public class threewheeler : IVehicle
	{
		public threewheeler()
		{
		}

		public void Drive()
		{
			Console.WriteLine("lesgetitt");
		}
	}
}

