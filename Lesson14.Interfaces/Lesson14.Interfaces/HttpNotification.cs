using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14.Interfaces
{
    public class HttpNotification : INotification
    {
        public void Notify(string messege)
        {
            Console.WriteLine($"With http cat say mew!");
        }
    }
}
