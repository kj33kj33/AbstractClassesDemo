using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
		public Vehicle()
		{
		}

		public string Make { get; set; } = "Make";
		public string Model { get; set; } = "Model";
		public int Year { get; set; } = 2000;

		public abstract void DriveAbstract(Vehicle vehicle);

		public virtual void DriveVirtual(Vehicle vehicle)
		{
			Console.WriteLine($"The {vehicle.Model} virtually drives.");
		}
	}
}

