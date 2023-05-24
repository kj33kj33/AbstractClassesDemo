using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}

        public bool HasSideCar { get; set; }

        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine($"The {vehicle.Make} drives.");
        }

        public override void DriveVirtual(Vehicle vehicle)
        {
            base.DriveVirtual(vehicle);
        }
    }
}

