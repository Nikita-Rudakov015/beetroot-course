﻿using System;

namespace Lesson04.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = Sum(10, 20);
            Console.WriteLine(sum);
            Console.WriteLine(Sum(10, 20));
            Console.WriteLine(Sum(10, 20, true));
            Console.WriteLine(Sum(10, 20, false));

            Console.WriteLine(IsOdd(11));
            Console.WriteLine(IsOdd(10));
            Console.WriteLine(SumNumbers(5,10));

            int i = 10;
            Increment(ref i);
            Increment(ref i);

            Console.WriteLine(i);

            if(TryDivide(100, 10, out int result))
            {
                Console.WriteLine(result);
            }
            if (!TryDivide(11, 10, out result))
            {
                Console.WriteLine(result);
            }

            Concat("10", "20");         //10, 20
            Concat("10", "20", "30");   //10, 20, 30
            Concat("10", "20", "30", "40");  
            Concat("10", "20", "30", "40", "50");  
            Concat("10");  

            Console.WriteLine(Factorial(5));                //120  
            Console.WriteLine(FactorialRecursive(5));      //120  
            Console.WriteLine(nameof(FactorialRecursive));     

            void write2(string str)
            {
                Console.WriteLine(str);
            }
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, bool r = true)
        {
            if (r)
            {
                return a + b;
            } else
            {
                return a - b;
            }
        }

        static bool IsOdd(int x)
        {
            return x % 2 == 0;
        }

        static int SumNumbers(int a, int b)
        {
            int sum = 0;
            for(int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Increment(ref int i)
        {
            i++;
        }

        static bool TryDivide(int a, int b, out int result)
        {
            result = a / b; 
            return a % b == 0;
        }

        static void Concat(string str1, string str2)
        {
            Console.WriteLine($"{str1}");
        }

        static void Concat(string str1, string str2, string str3)
        {
            Console.WriteLine($"{str1} {str2} {str3}");
        }

        static void Concat(params string[] strings)
        {
            Console.WriteLine(strings.Length);
        }

        static int Factorial(int value)
        {
            int result = 1;
            for (int i = value; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }


        // 1 - value = 5
        // 2 - value = 4
        // 3 - value = 3
        static int FactorialRecursive(int value)
        {
            if (value == 1) return value;
            Console.WriteLine($"{nameof(value)} -> {value}");
            return value * FactorialRecursive(value - 1);
            //value * value - 1 * value - 2 * value - 3
            //5 * 4 * 3 * 2 *1
        }
    }
}
