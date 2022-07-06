using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Inheritance
{
    public class Engine : AutoService
    {
        public Engine(Vehicle vehicle) : base(vehicle)
        {

        }
    }
}
