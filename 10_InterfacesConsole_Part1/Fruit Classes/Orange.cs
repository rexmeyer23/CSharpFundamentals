using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part1.Fruit_Classes
{
    public class Orange : IFruit
        //interface requires implementing all members from respective interface
    {
        public string Name { get; set; }//can add set in here because met requirements of IFruit interface, logic in Peel method shows requirments were met
        public bool Peeled { get; set; }
        public string Peel()
        {
            Peeled = true;
            return "Orange is peeled";
        }
    }
}
