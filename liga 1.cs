using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemograman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            taxi taxi = new taxi();

            taxi.DriverName = "marto";
            taxi.OnDuty = "true";
            taxi.NumberOfPassenger = "10";

            taxi.taxInfo();
            taxi.PickupPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();


            
        }
    }
}
