using System;

namespace Lesson13.Inheritance
{
    public class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine($"{this.Name} said Gav!");
        }
    } 
}
