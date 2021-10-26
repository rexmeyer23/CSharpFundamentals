using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2.RentalVehicles
{
    //A rental car is a type of rental vehicle so this works. Rental vehicle can be inherited
    public enum CarType { Hatchback, Sedan, Compact}
    public class RentalCar : RentalVehicle
    {
        public CarType CarType { get; set; }
    }
}
