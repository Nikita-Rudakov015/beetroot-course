using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Inheritance
{
    public class FreightVehicle : Vehicle
    {
        public override void AssemblyOfVehicle()
        {
            Console.WriteLine("Assembly of freight vehicle!");
        }
    }
}
