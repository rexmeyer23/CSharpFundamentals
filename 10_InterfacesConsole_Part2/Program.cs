﻿using _10_InterfacesConsole_Part2.Interfaces;
using _10_InterfacesConsole_Part2.RentalVehicles;
using _10_InterfacesConsole_Part2.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2
{
    //Inheritance used to associate parent base class with child classes
    //Employee inherits from Person class, not Person inherit from Employee
    //another example is Dog inherits from Animal class
    class Program
    {
        //Inheritance is used to associate a parent base class with its child relationships ---> Animal -----> Cat -------> Lion

        //Interfaces is a contract with a set of requirements. 

        //Inheritance:

        //1. Inheritance is not code-sharing
        //code-sharing is where we use a class or its members in another class for Example: using Episode in the show class or referencing a method from one class in another class.

        //2. Is-a Relationship Is a lion a cat....is a cat an Animal.

        //3. Need to share some common logic
        //sharing just properties or method signatures is not enough
        //if they all have completely different implementation this would be pointless might as well just write a brand new method

        //4. Inheritance can put you in a corner
        //when you overstretch the Is-a relationship. So this results in very tightly coupled code.

        //5. You ask what is the point
        //what is the value that you are creating. 

        static void Main(string[] args)
        {

            //RentalSailBoat sb = new RentalSailBoat();

            //sb.StartEngine(); //a sailboat does not have an engine -----> bad code

            //SailBoat sailBoat = new SailBoat();

            List<IRental> rentals = new List<IRental>();

            rentals.Add(new Truck() { RentalID = 1, CurrentRenter = "Truck Renter", TruckStyle = Vehicles.TruckType.Longbed });
            rentals.Add(new Car()
            {
                RentalID = 2,
                CurrentRenter
             = "Car Renter",
                CarStyle = Vehicles.CarType.Sedan
            });
            rentals.Add(new SailBoat() { RentalID = 3, CurrentRenter = "Sail Boat Renter", SailBoatStyle = Vehicles.SailBoatType.Boat2 });

            foreach (IRental rental in rentals)
            {
                if (rental is Truck t)
                {
                    Console.WriteLine("The {0} rented a {1} which has a RentalID of {2}", t.CurrentRenter, t.TruckStyle, t.RentalID);
                }
                else if (rental is Car c)
                {
                    Console.WriteLine("The {0} rented a {1} which has a RentalID of {2}", c.CurrentRenter, c.CarStyle, c.RentalID);
                }
                else if (rental is SailBoat sb)
                 {
                    Console.WriteLine("The {0} rented a {1} which has a RentalID of {2}", sb.CurrentRenter, sb.SailBoatStyle, sb.RentalID);
                }
            }
        }
    }
}
