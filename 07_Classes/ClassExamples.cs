using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes
{//object is an instance or creation from class, class is the blueprint (class allows diverging like a blueprint)
    //property is a data value that can be set or retrieved from the class
    //class library is another type of project, it holds classes, its a place where all object classes go
    //frameworks encompass a language, unit test project and console app are both types of projects
    //camelCase = variables
    //PascalCase = Methods, Classes, Properties
    //_camelCase = fields

    public enum VehicleType { Car, Truck, SUV, MiniVan, Coupe, Boat }
    public class Vehicle
    {
        //internal access modifier can only be accessed within the name space
        //private access modifier can only be accessed in respective class or method
        //accessModifier   type  property name{get; set;}
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double Mileage { get; set; }
        public VehicleType Type { get; set; }
        //properties and methods are class members
        //constructer is not a class member

        public Vehicle()
        {

        }
        public Vehicle(string make, string model, int year, double mileage, string color, VehicleType type)
        {
            Make = make;
            Year = year;
            Model = model;
            Color = color;
            Mileage = mileage; 
            Type = type;
        }

    }
    public class Person
    {   //private _field often referred to as backing field, can get and set 
    
        //age
        //height
        //gender
        //weight
        //DateOfBirth
        //FirstName
        //LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public DateTime DateOfBirth { get; set; }
        public int AgeInYears
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                //DateTime.Now is  a static method
                double totalAgeInYears = ageSpan.TotalDays / 366.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYears));
            }
        }
        public Vehicle Transport { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName, DateTime dateOfBirth, Vehicle transport)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Transport = transport;
        }
    }
}
