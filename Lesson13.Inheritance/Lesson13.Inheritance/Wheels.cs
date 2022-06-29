using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Inheritance
{
    public class Wheels : AutoService
    {
        public Wheels(Vehicle veheicle) : base(veheicle)
        {

        }
    }
}
