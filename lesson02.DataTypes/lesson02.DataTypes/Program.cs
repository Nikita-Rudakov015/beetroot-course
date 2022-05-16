using System;

namespace lesson02.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            int si = -3000;

            Console.WriteLine(a * 3);
            Console.WriteLine(18 / b);
            Console.WriteLine(10 / 3);

            short biiigint = 3200;
            short biiigint1 = 3200;

            short result1 = (short)(biiigint + short.Parse("3200"));


            int resultint = biiigint;

            Console.WriteLine(a << b);
            Console.WriteLine(a >> 100);

            bool aBool = true;
            bool bBool = false;
            Console.WriteLine(aBool | bBool);     //побитовое или 
            Console.WriteLine(aBool || bBool);    //логичиское или

            //6-  00000110
            //10- 00001010
            Console.WriteLine(6 ^ 10); //12

            //homework
            int x = 5, y = 10;
            Console.WriteLine($"The first task: {-6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15}");
            Console.WriteLine($"The second task: {Math.Abs(x) * Math.Sin(x)}");
            Console.WriteLine($"The third task: {2 * Math.PI * x}");
            Console.WriteLine($"The fourth task: {Math.Max(x, y)}");


            //Extra
            DateTime dat = DateTime.Now;
            Console.WriteLine("\nToday is {0:d} at {0:T}.", dat);
            //System.DateTime date1 = new System.DateTime(2022, 4, 30, 21, 05, 52);
            System.DateTime date2 = new System.DateTime(2023, 1, 1, 00, 00, 0);
            System.DateTime date3 = new System.DateTime(2021, 1, 1, 00, 00, 0);
            System.TimeSpan diff1 = date2 - dat;
            System.TimeSpan diff2 = dat - date3;
            Console.WriteLine($"How many days until The New Year 2023:  {diff1}");
            Console.WriteLine($"How many days passed since The New Year 2021:  {diff2}");
        }
    }
}
