using System;

namespace Lesson13.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal
            {
                Name = "Sima",
                PawsCount = 4
            };
            Cat cat = new Cat
            {
                Name = "Kapuchinka",
                PawsCount = 4
            };

            Dog dog = new Dog
            {
                Name = "Lucky",
                PawsCount = 4
            };
            Console.WriteLine($"Animal {animal.Name} with {animal.PawsCount} paws");
            Console.WriteLine($"Cat {cat.Name} with {cat.PawsCount} paws");

            animal.MakeNoise();
            cat.MakeNoise();
            dog.MakeNoise();

            Animal a;

            a = new Cat
            {
                Name = "Busya"
            };
            a.MakeNoise();
            Console.WriteLine(a.GetType());
            Console.WriteLine(a is Cat);
            Console.WriteLine(a is Dog);

            a = new Dog
            {
                Name = "Lucky"
            };
            a.MakeNoise();
            Console.WriteLine(a.GetType());
            Console.WriteLine(a is Cat);
            Console.WriteLine(a is Dog);

            Cat anotherCat = new Cat
            {
                Name = "Kapuchinka",
                PawsCount = 4
            };

            Console.WriteLine($"{cat.Name} equal {anotherCat.Name} = {cat.Equals(anotherCat)}");
            Console.WriteLine(cat.Equals(cat));

            object obj1 = 4;
            object obj2 = "Some string";

            Console.WriteLine(obj1.ToString());
            Console.WriteLine(obj2.ToString());
            Console.WriteLine(obj1.GetType());
            Console.WriteLine(obj2.GetType());

            obj1 = false;
            Console.WriteLine(obj1.ToString());
            Console.WriteLine(obj1.GetType());
            Console.WriteLine(obj1 as int?);

            Noise noise;
            noise = new FlyNoise();
            noise.MakeNoise();

            noise = new JustNoise();
            noise.MakeNoise();

            var duck = new Duck(new FlyNoise());
            var duck1 = new Duck(new JustNoise());
            duck.MakeNoise();
            duck1.MakeNoise();
        }
    }
}
