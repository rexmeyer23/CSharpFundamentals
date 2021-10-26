using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfacesConsole_Part2.RentalVehicles
{
    //A rental boat is a type of rental vehicle so this works. Rental vehicle can be inherited, BUT the client says "we actually have to types of boat rentals: motor boats and sail boats"
        //sail boat does not have an ignition
    public class RentalBoat : RentalVehicle
    {

    }
}
