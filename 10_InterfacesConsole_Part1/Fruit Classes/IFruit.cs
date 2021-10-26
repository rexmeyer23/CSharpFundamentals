using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part1.Fruit_Classes
{
    public interface IFruit
    {
        string Name { get;}//Property with only a get
        //can not have private member inside of an interface
        bool Peeled { get; set; }//Property with a get and a set
        string Peel();//Method with only a return type and no parameters or business logic { business logic goes in curly braces}
        //interface does not need logic implemented, put logic in what you implement interface in the class you want
    }
}
