using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objet taxi
            taxi taxi = new taxi();

            //penemuan nilai properties
            taxi.DriverName = "jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DroppOffPassenger();

            Console.ReadKey();
        }
    }
}
