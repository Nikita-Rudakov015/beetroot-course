using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Inheritance
{
    public class PassengerVehicle : Vehicle
    {
        public override void AssemblyOfVehicle()
        {
            Console.WriteLine("Assembly of passenger vehicle!");
        }
    }
}
