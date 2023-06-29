using BikeApp.Models.Enum;

namespace BikeApp.Models
{
	public class Bike
	{
	    public int Id { get; set; }
		public string ManufacturingCame { get; set; }
		public int WheelDiameter { get; set; }
		public int Gears { get; set; } 
		public bool HasHydrauslic { get; set; }
		public BikeType BikesType { get; internal set; }
		BikeType BikeType { get; set; }
	}
}
