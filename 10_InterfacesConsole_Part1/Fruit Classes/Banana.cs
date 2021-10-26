using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part1.Fruit_Classes
{
    public class Banana : IFruit
    {
        public string Name { get; set;}

        public bool Peeled { get; set; }
        //can change access modifier once it is in class, like public to private
        public string Peel()
        {
            Peeled = true;
            return "Banana is peeled";
        }
    }
}
