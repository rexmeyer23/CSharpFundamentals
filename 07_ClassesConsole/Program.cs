using _07_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClassesConsole
{
    class Program
    {//properties and methods are class members
        //constructer is not a class member
        static void Main(string[] args)
        {
            Vehicle firstVehicle = new Vehicle();

            firstVehicle.Make = "Honda";
            firstVehicle.Model = "Civic";
            firstVehicle.Year = 2012;
            firstVehicle.Type = VehicleType.Car;
            firstVehicle.Mileage = 150000;
            firstVehicle.Color = "gray";

            Vehicle secondVehicle = new Vehicle("Chevy", "Silverado", 1994, 98000, "black", VehicleType.Truck );

            Console.WriteLine(secondVehicle.Make);

            Console.ReadLine();

            Person firstPerson = new Person("Gary", "Banks", new DateTime(1991,08,24), firstVehicle);

            Console.WriteLine(firstPerson.FullName);
            Console.WriteLine(firstPerson.AgeInYears);
            Console.WriteLine(firstPerson.Transport.Make);

            Console.ReadKey();
        }
    }
}
