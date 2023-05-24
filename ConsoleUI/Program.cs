using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles

            List<Vehicle> vehicleList = new List<Vehicle>();

            Car fJ = new Car()
            {
                Make = "Toyota",
                Model = "FJ Cruiser",
                Year = 2005,
                HasTrunk = true
            };

            Motorcycle harley = new Motorcycle()
            {
                Make = "Harley Davidson",
                Model = "Fat Boy",
                Year = 1998,
                HasSideCar = false
            };

            Vehicle hummer = new Car()
            {
                Make = "Hummer",
                Model = "H2",
                Year = 2005,
                HasTrunk = true
            };

            Vehicle ninja = new Motorcycle()
            {
                Make = "Kawasaki",
                Model = "Ninja",
                Year = 2010,
                HasSideCar = false
            };

            vehicleList.Add(fJ);
            vehicleList.Add(harley);
            vehicleList.Add(hummer);
            vehicleList.Add(ninja);

            Console.WriteLine("\n====================================");
            Console.WriteLine("\nThe following cars are on the list:\n");
            foreach(var vehicle in vehicleList)
            {
                Console.WriteLine($"A {vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }

            hummer.DriveAbstract(hummer);
            fJ.DriveVirtual(fJ);
            ninja.DriveAbstract(ninja);
            harley.DriveVirtual(harley);

            #endregion            
            Console.ReadLine();
        }
    }
}
