using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Inheritance
{
    public class AutoService
    {
        private readonly Vehicle _vehicle;

        public AutoService(Vehicle vehicle)
        {
            this._vehicle = vehicle;
        }

        public virtual void AssemblyOfVehicle()
        {
            this._vehicle.AssemblyOfVehicle();
        }
    }
}
