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
                PassCount = 4
            };
            Cat cat = new Cat
            {
                Name = "Kapuchinka",
                PassCount = 4
            };

            Dog dog = new Dog
            {
                Name = "Lucky",
                PassCount = 4
            };
            Console.WriteLine($"Animal {animal.Name} with {animal.PassCount} paws");
            Console.WriteLine($"Cat {cat.Name} with {cat.PassCount} paws");

            animal.MakeNoise();
            cat.MakeNoise();
            dog.MakeNoise();

            Animal a;

            a = new Cat
            {
                Name = "Busya"
            };
            a.MakeNoise();

            a = new Dog
            {
                Name = "Lucky"
            };
            a.MakeNoise();

            Cat anotherCat = new Cat
            {
                Name = "Kapuchinka",
                PassCount = 4
            };

            Console.WriteLine(cat.Equals(anotherCat));
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
            /*Animal animal = new Animal
            {
                Name = "Сiма",
                PawsCount = 4
            };

            Cat cat = new Cat
            {
                Name = "Капучiнка",
                PawsCount = 4
            };

            Dog dog = new Dog
            {
                Name = "Лакi",
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
                Name = "Буся"
            };
            a.MakeNoise();
            Console.WriteLine(a.GetType());
            Console.WriteLine(a is Cat);
            Console.WriteLine(a is Dog);

            a = new Dog
            {
                Name = "Лакi"
            };
            a.MakeNoise();
            Console.WriteLine(a.GetType());
            Console.WriteLine(a is Cat);
            Console.WriteLine(a is Dog);

            Cat anotherCat = new Cat
            {
                Name = "Капучiнка",
                PawsCount = 4
            };
            Console.WriteLine($"{cat.Name} equal {cat.Equals(anotherCat)}");
            Console.WriteLine($"{cat.Equals(cat)}");

            object obj1 = 4;
            object obj2 = "якась стрiчка";

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

            Duck duck = new Duck(new FlyNoise());
            Duck duck1 = new Duck(new JustNoise());
            duck.MakeNoise();
            duck1.MakeNoise();*/


        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public int PassCount { get; set; }
        public int Size { get; set; }

        public virtual void MakeNoise()
        {

        }
    }

    public class Cat : Animal
    {
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;

            if (ReferenceEquals(obj, null)) return false;

            Cat? cat = obj as Cat;           //savecast к типу данных в который хотим перевести
            if (obj is Cat)
            {

            }
            return false;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{this.Name} said Mew!");
        }
    }

    public class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine($"{this.Name} said Gav!");
        }
    }

    /*public abstract class Noise
    {
        public abstract void MakeNoise();
    }

    public class FlyNoise : Noise
    {
        public override void MakeNoise()
        {
            Console.WriteLine($"Лiтаюча кря!");
        }
    }

    public class SilentNoise : Noise
    {
        public override void MakeNoise()
        {
            Console.WriteLine($"Тихий кря!");
        }
    }

    public class JustNoise : Noise
    {
        public override void MakeNoise()
        {
            Console.WriteLine($"Просто кря!");
        }
    }

    public class Duck
    {
       private readonly Noise noise;
        
       public Duck(Noise noise)
        {
            this.noise = noise;
        }

       public virtual void MakeNoise()
        {
            this.noise.MakeNoise();
        }
    }*/

    /*public class RuberDuck : Duck
    {
        public virtual void MakeNoise()
        {
        }
    }

    public class RealDuck : Duck
    {
        
    }*/

   /* public class FlyDuck : RealDuck
    {
        public override void MakeNoise()
        {
            Console.WriteLine($"Лiтаюча кря!");
        }
    }*/

    /*public class Animal
    {
        public string Name { get; set; }
        public int PawsCount { get; set; }
        public int Size { get; set; }
        
        public virtual void MakeNoise()
        {

        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            Animal? animal = obj as Animal;
            if (animal == null)
            {
                return false;
            }

            if (this.Name != animal.Name) return false;
            if (this.Size != animal.Size) return false;
            if (this.PawsCount != animal.PawsCount) return false;

            return true;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }

    public class Cat : Animal
    {        
        public override void MakeNoise()
        {
            Console.WriteLine($"{this.Name} сказала Няв!");
        }
    }

    public class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine($"{this.Name} сказал Гав-гав!");
        }
    }*/
}
