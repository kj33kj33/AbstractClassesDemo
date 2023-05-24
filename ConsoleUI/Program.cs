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

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

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

            hummer.DriveAbstract(hummer);
            fJ.DriveVirtual(fJ);
            ninja.DriveAbstract(ninja);
            harley.DriveVirtual(harley);

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
