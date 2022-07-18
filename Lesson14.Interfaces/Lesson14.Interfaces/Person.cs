using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14.Interfaces
{
    public class Person
    {
        private readonly string _name;

        public Person(string name)
        {
            this._name = name;
        }

        public void Print()
        {
            Console.WriteLine(this._name);
        }
    }
}
