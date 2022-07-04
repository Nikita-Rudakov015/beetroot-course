using System;
using System.Net.Http;

namespace Lesson14.Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Cat(new ConsoleNotification());
            animal.Noise();

            INotification notification = new ConsoleNotification();
            notification.Notify("eed");

            INotification notification1 = new HttpNotification();
            notification1.Notify("1234");

            new MyClass().Print(4);
            new Person("Nikita").Print();
        }

        private void Print(int a)
        {
            Console.WriteLine(a);
        }
    }

    public enum NoiseType
    {
        Console = 1,
        Http = 2,
        Smtp = 3
    }
}
