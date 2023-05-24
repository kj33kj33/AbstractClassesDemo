using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		}

		public bool HasTrunk { get; set; }

		public override void DriveAbstract(Vehicle vehicle)
		{
			Console.WriteLine($"The {vehicle.Make} drives.");
		}
	}
}

