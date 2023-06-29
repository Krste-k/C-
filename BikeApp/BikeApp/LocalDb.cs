using BikeApp.Models;
using BikeApp.Models.Enum;

namespace BikeApp
{
	public class LocalDb
	{
		public static List<Bike> bikes = new List<Bike>
		{
			new Bike
			{
				Id = 1,
				ManufacturingCame ="Shimano",
				WheelDiameter = 18,
				Gears = 18,
				HasHydrauslic = true,
				BikesType = BikeType.Road
			},
				new Bike
			{
				Id = 2,
				ManufacturingCame ="Bike2",
				WheelDiameter = 22,
				Gears = 24,
				HasHydrauslic = false,
				BikesType = BikeType.city
			},
			new Bike
			{
				Id = 3,
				ManufacturingCame ="Bike3",
				WheelDiameter = 24,
				Gears = 24,
				HasHydrauslic = true,
				BikesType = BikeType.Mountine
			}
		};
	}
}
