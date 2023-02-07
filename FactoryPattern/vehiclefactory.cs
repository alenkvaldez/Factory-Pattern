using System;
namespace FactoryPattern
{
	public static class vehiclefactory
	{
		public static IVehicle GetVehicle(int wheelCount)
		{
			switch (wheelCount)
			{
				case 2:
					return new motorcycle();
				case 3:
					return new threewheeler();
				case 4:
					return new car();
				default:
					return new car();
				}
			}
		}
	}

