using System;
using System.Net.Http;

namespace Lesson14.Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            var notification = new ConsoleNotification();
            Animal animal = new Cat(notification);
            animal.Noise();

            INotification notification1 = new ConsoleNotification();
            notification1.Notify("def");

            INotification notification2 = new HttpNotification();
            notification1.Notify("132");

            new MyClass().Print(4);
            new Person("Nikita").Print();
        }

        public class Person
        {
            private string _name;

            public Person(string name)
            {
                this._name = name;
            }

            public void Print()
            {
                Console.WriteLine(this._name);
            }
        }

        public class MyClass
        {
            public void Print(int a)
            {
                Console.WriteLine(a);
            }
        }

        public interface INotification
        {
            void Notify(string message);
        }

        public class ConsoleNotification : INotification
        {
            public void Notify(string messege)
            {
                Console.WriteLine("Cat mews!");
            }
        }

        public class HttpNotification : INotification
        {
            public void Notify(string messege)
            {
                Console.WriteLine("Cat mews from http!");
            }
        }

        public abstract class Animal
        {
            public abstract void Noise();
        }

        public class Cat : Animal
        {
            private INotification notification;

            public Cat(ConsoleNotification notification)
            {
                this.notification = notification;
            }

            public override void Noise()
            {
                notification.Notify("Cat meows");
            }
        }
    }

    public enum NoiseType
    {
        Console = 1,
        Http = 2
    }
}
