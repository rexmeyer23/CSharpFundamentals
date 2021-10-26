using _10_InterfacesConsole_Part2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2.Vehicles
{
    public enum CarType { hatchback, Sedan, Compact }
    //do not have to use above enum because it is in rental vehicle class folder
    public class Car : LandVehicle, IRental
    {
        public int RentalID { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
        public CarType CarStyle { get; set; }
    }
}
