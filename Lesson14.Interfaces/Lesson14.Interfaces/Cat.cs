using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14.Interfaces
{
    public class Cat : Animal
    {
        private INotification notification;

        public Cat(INotification notification)
        {
            this.notification = notification;
        }

        public override void Noise()
        {
            notification.Notify("Some sessege");
        }
    }
}
