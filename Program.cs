using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassdanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();
 
            taxi.DriveName = "Jono";
            taxi.OnDuty = true;
            taxi.NumbOfPassenger = 10;

            taxi.PickInfo();
            taxi.PickUpPassenger();
            taxi.DropOfPassenger();

            Console.Readkey();
        }
     }
}