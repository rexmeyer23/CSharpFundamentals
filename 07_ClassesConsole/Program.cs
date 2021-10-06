
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
            //PersonRepository repo = new PersonRepository();//Instance of the repository class
            //have to make an instance in order to access another class
            //Objects are items that you create a blueprint for
            int numOne = 1;
            PersonRepository repo = new PersonRepository();
          
            //Object
            Person person1 = new Person();
            person1.FirstName = "Rex";
            repo.AddPerson2(person1);
            Person person2 = new Person();
            person2.FirstName = "Sam";
            repo.AddPerson2(person2);
            Person person3 = new Person();


            //repo.AddPerson(person3);

            //List<Person> localList = repo.ReturnListOfPeople();

            //localList.Add(person1);
            //localList.Add(person3);

            //person1.FirstName = "Mason";
            //person2.FirstName = "Anna";

            //Person updatedPerson = repo.UpdatePerson(person1, person2);
            //expressions read from right to left
            //Console.WriteLine(updatedPerson.FirstName);

            Console.ReadKey();

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
    //Repository Pattern is similar to how you structure your code.
    //Decouples data layer
    //Business logic methods that handle the exchange between the user and database, bery specific that hanfle exchange between collection and what the user sees
    //CRUD Methods
    //Create
    //Read
    //Update
    //Delete
}
