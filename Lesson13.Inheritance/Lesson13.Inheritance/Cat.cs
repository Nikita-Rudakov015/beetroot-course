using System;

namespace Lesson13.Inheritance
{
    public class Cat : Animal
    {       
        public override void MakeNoise()
        {
            Console.WriteLine($"{this.Name} said Mew!");
        }
    }
}
