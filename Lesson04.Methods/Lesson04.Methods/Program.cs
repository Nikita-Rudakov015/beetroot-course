using System;
using System.Linq;

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
            // homework
            Console.WriteLine($"\nPlease enter variant of mehtods 1-5: \n" +
                $"1) Method that will return max value among all the parameters \n" +
                $"2) Method that will return min value among all the parameters \n" +
                $"3) Method TrySumIfOdd that accepts 2 parameters and returns true if sum of numbers between inputs is odd, otherwise false \n" +
                $"4) Overload first two methods with 3 and 4 parameters \n" +
                $"5) Method Repeat, which repeat your string N times");
            var variant = Console.ReadLine();
            var Variant = Convert.ToInt32(variant);

            switch (Variant)
            {
                case 1:
                    Console.WriteLine("Please enter two integer numbers: ");
                    var FirstNumMax = Console.ReadLine();
                    var SecondNumMax = Console.ReadLine();
                    int firstMax = Convert.ToInt32(FirstNumMax);
                    int secondMax = Convert.ToInt32(SecondNumMax);

                    Console.WriteLine($"Method MaxValue: {MaxValue(firstMax, secondMax)}");
                    break;
                case 2:
                    Console.WriteLine("Please enter two integer numbers: ");
                    var FirstNumMin = Console.ReadLine();
                    var SecondNumMin = Console.ReadLine();
                    int firstMin = Convert.ToInt32(FirstNumMin);
                    int secondMin = Convert.ToInt32(SecondNumMin);

                    Console.WriteLine($"Method MinValue: {MinValue(firstMin, secondMin)}");
                    break;
                case 3:
                    Console.WriteLine("Please enter two integer numbers: ");
                    var FirstNumSum = Console.ReadLine();
                    var SecondNumSum = Console.ReadLine();
                    int firstSum = Convert.ToInt32(FirstNumSum);
                    int secondSum = Convert.ToInt32(SecondNumSum);

                    Console.WriteLine($"Metod TrySumIfOdd: {TrySumIfOdd(firstSum, secondSum, out int Sum)}");
                    break;
                case 4:
                    //Max - 3
                    Console.WriteLine($"Please enter three integer numbers for MaxValue with 3 parameters: ");
                    var FirstOverloadMaxT = Console.ReadLine();
                    var SecondOverloadMaxT = Console.ReadLine();
                    var ThirdOverloadMaxT = Console.ReadLine();
                    int firstOverMaxT = Convert.ToInt32(FirstOverloadMaxT);
                    int secondOverMaxT = Convert.ToInt32(SecondOverloadMaxT);
                    int thirdOverMaxT = Convert.ToInt32(ThirdOverloadMaxT);


                    Console.WriteLine($"Method overloading MaxValue with 3 parameters: {MaxValue(firstOverMaxT, secondOverMaxT, thirdOverMaxT)}");
                    //Max - 4
                    Console.WriteLine($"Please enter four integer numbers for MaxValue with 4 parameters: ");
                    var FirstOverloadMax = Console.ReadLine();
                    var SecondOverloadMax = Console.ReadLine();
                    var ThirdOverloadMax = Console.ReadLine();
                    var FourhOverloadMax = Console.ReadLine();
                    int firstOverMax = Convert.ToInt32(FirstOverloadMax);
                    int secondOverMax = Convert.ToInt32(SecondOverloadMax);
                    int thirdOverMax = Convert.ToInt32(ThirdOverloadMax);
                    int fourthOverMax = Convert.ToInt32(FourhOverloadMax);

                    Console.WriteLine($"Method overloading MaxValue with 4 parameters: {MaxValue(firstOverMax, secondOverMax, thirdOverMax, fourthOverMax)}");


                    //Min - 3
                    Console.WriteLine("Please enter four integer numbers for MinValue with 3 parameters: ");
                    var FirstOverloadMinT = Console.ReadLine();
                    var SecondOverloadMinT = Console.ReadLine();
                    var ThirdOverloadMinT = Console.ReadLine();
                    int firstOverMinT = Convert.ToInt32(FirstOverloadMinT);
                    int secondOverMinT = Convert.ToInt32(SecondOverloadMinT);
                    int thirdOverMinT = Convert.ToInt32(ThirdOverloadMinT);

                    Console.WriteLine($"Method overload MinValue with 3 parameters: {MinValue(firstOverMinT, secondOverMinT, thirdOverMinT)}");
                    //Min - 4
                    Console.WriteLine("Please enter four integer numbers for MinValue with 4 parameters: ");
                    var FirstOverloadMin = Console.ReadLine();
                    var SecondOverloadMin = Console.ReadLine();
                    var ThirdOverloadMin = Console.ReadLine();
                    var FourhOverloadMin = Console.ReadLine();
                    int firstOverMin = Convert.ToInt32(FirstOverloadMin);
                    int secondOverMin = Convert.ToInt32(SecondOverloadMin);
                    int thirdOverMin = Convert.ToInt32(ThirdOverloadMin);
                    int fourthOverMin = Convert.ToInt32(FourhOverloadMin);

                    Console.WriteLine($"Method overload MinValue with 4 parameters: {MinValue(firstOverMin, secondOverMin, thirdOverMin, fourthOverMin)}");
                    break;
                case 5:
                    Console.WriteLine("Please enter your string, which will repeat N times\nPlease enter your string");
                    var StringRepeat = Console.ReadLine();
                    Console.WriteLine("Please enter number how many times");
                    var NumberRepeat = Console.ReadLine();
                    int NumRepeat = Convert.ToInt32(NumberRepeat);                  

                    Console.WriteLine($"Method Repeat: {Repeat(StringRepeat, NumRepeat)}");
                    break;
                default:
                    Console.ReadLine();
                    break;
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

        //homework
        static int MaxValue(int firstMax, int secondMax)
        {
            return Math.Max(firstMax, secondMax);
        }

        static int MinValue(int firstMin, int secondMin)
        {
            return Math.Min(firstMin, secondMin);
        }

        static bool TrySumIfOdd(int firstNumSum, int secondNumSum, out int sum)
        {
            sum = firstNumSum + secondNumSum;
            if(sum % 2 == 1)
            {
                Console.WriteLine("Sum is odd: ");
                return true;
            }
            else 
            {
                Console.WriteLine("Sum is not odd: ");
                return false;
            }
        }

        static int MaxValue(int firstOverMax, int secondOverMax, int thirdOverMax, int fourthOverMax)
        {
            if(firstOverMax > secondOverMax && firstOverMax > thirdOverMax && firstOverMax > fourthOverMax)
            {
                return firstOverMax;
            } else if(secondOverMax > firstOverMax && secondOverMax > thirdOverMax && secondOverMax > fourthOverMax)
            {
                return secondOverMax;
            } else if(thirdOverMax > firstOverMax && thirdOverMax > fourthOverMax && thirdOverMax > secondOverMax)
            {
                return thirdOverMax;
            } else if (fourthOverMax > firstOverMax && fourthOverMax > thirdOverMax && fourthOverMax > secondOverMax)
            {
                return fourthOverMax;
            } else if(firstOverMax == secondOverMax && firstOverMax == thirdOverMax && firstOverMax == fourthOverMax)
            {
                return firstOverMax;
            }
            return 1;
        }

        static int MinValue(int firstOverMin, int secondOverMin, int thirdOverMin, int fourthOverMin)
        {
            if (firstOverMin < secondOverMin && firstOverMin < thirdOverMin && firstOverMin < fourthOverMin)
            {
                return firstOverMin;
            }
            else if (secondOverMin < firstOverMin && secondOverMin < thirdOverMin && secondOverMin < fourthOverMin)
            {
                return secondOverMin;
            }
            else if (thirdOverMin < firstOverMin && thirdOverMin < fourthOverMin && thirdOverMin < secondOverMin)
            {
                return thirdOverMin;
            }
            else if (fourthOverMin < firstOverMin && fourthOverMin < thirdOverMin && fourthOverMin < secondOverMin)
            {
                return fourthOverMin;
            }
            else if (firstOverMin == secondOverMin && firstOverMin == thirdOverMin && firstOverMin == fourthOverMin)
            {
                return firstOverMin;
            }
            return 1;
        }

        static int MaxValue(int firstOverMax, int secondOverMax, int thirdOverMax)
        {
            if (firstOverMax > secondOverMax && firstOverMax > thirdOverMax)
            {
                return firstOverMax;
            }
            else if (secondOverMax > firstOverMax && secondOverMax > thirdOverMax)
            {
                return secondOverMax;
            }
            else if (thirdOverMax > firstOverMax && thirdOverMax > secondOverMax)
            {
                return thirdOverMax;
            } 
            else if (firstOverMax == secondOverMax && firstOverMax == thirdOverMax)
            {
                return firstOverMax;
            }
            return 1;
        }

        static int MinValue(int firstOverMin, int secondOverMin, int thirdOverMin)
        {
            if (firstOverMin < secondOverMin && firstOverMin < thirdOverMin)
            {
                return firstOverMin;
            }
            else if (secondOverMin < firstOverMin && secondOverMin < thirdOverMin)
            {
                return secondOverMin;
            }
            else if (thirdOverMin < firstOverMin && thirdOverMin < secondOverMin)
            {
                return thirdOverMin;
            }      
            else if (firstOverMin == secondOverMin && firstOverMin == thirdOverMin)
            {
                return firstOverMin;
            }
            return 1;
        }

        static string Repeat(string X, int N)
        {
            if (N < 1)
            {
                return "Incorrect input";
            }
            return string.Concat(Enumerable.Repeat(X, N));
        }
    }
}
