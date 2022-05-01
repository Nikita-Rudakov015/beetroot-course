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


        }
    }
}
