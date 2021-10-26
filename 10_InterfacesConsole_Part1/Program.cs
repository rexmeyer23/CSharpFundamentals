using _10_InterfacesConsole_Part1.Fruit_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part1
{
    class Program
    {
        //interface is different from a class because you can not make an instance of interface, can only make a new instance of class that implements that interface
        //interfaces are implemented in a similar way in how we inherit class, class can inherit multiple interfaces
        //members of interfaces have NO access modifiers
        //by default, all members of an interface are public
        static void Main(string[] args)
        {
            //Create an IFruit Collection

            List<IFruit> _fruits = new List<IFruit>();

            Orange orange = new Orange() { Name = "Orange" };//braces is an example of object notation, this allows us to slect properties we want to set the value of
            Banana banana = new Banana() { Name = "Banana" };
            Grape grape = new Grape() { Name = "Grape" };

            _fruits.Add(orange);
            _fruits.Add(banana);
            _fruits.Add(grape);

            foreach(IFruit fruit in _fruits)
            {
                if(fruit is Orange o)//o and fruit represent same thing, fruit class only has access to properties within fruit interface but orange has access to both, see example below
                {
                    //o.Name shows {get; set; }
                    //fruit.Name shows {get; }
                    Console.WriteLine("Is Orange peeled?");
                    Console.WriteLine(o.Peel());
                    Console.WriteLine("-------------------------");
                }
                else if(fruit is Banana b)
                {
                    Console.WriteLine("Is Banana Peeled?");
                    Console.WriteLine(b.Peel());
                    Console.WriteLine("-------------------------");
                }
                else if(fruit is Grape g)
                {
                    Console.WriteLine("Is Grape Peeled?");
                    Console.WriteLine(g.Peel());
                    Console.WriteLine("-------------------------");
                }
            }
            Console.ReadKey();
        }
    }
}
