using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemograman
{
    internal class taxi
    {
        // properties
        public string DriverName { get; set; }
        public string OnDuty { get; set; }
        public string NumberOfPassenger { get; set; }


        //method
        public void taxInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            Console.WriteLine("On Duty: {0} ", OnDuty);
            Console.WriteLine("Number Of Passenger: ", NumberOfPassenger);
        }

        public void PickupPassenger()
        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }


    }
}
