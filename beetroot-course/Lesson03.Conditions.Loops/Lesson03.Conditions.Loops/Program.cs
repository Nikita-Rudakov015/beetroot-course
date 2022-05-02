using System;

namespace Lesson03.Conditions.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            switch (a)
            {
                case 5:
                    Console.WriteLine($"A is  {a}");
                        break;
                case 6:
                    Console.WriteLine($"A is  {a}");
                    break;
            }

            const int N = 10;
            int sum = 0;
            int i = 0;
            for(; i<N; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of {N} is {sum}");

            i = 0;
            sum = 0;
            while(i != N)
            {
                sum += i++;
            }
            Console.WriteLine($"Sum of {N} is {sum}");

            do
            {
                sum += i++;
            } while(i < N);
            Console.WriteLine($"Sum of {N} is {sum}");

            i = 0;
            sum = 0;
            for(; i <N; i++)
            {
                sum += (i % 2 == 0) ?i :0;
            }
            Console.WriteLine(sum); 
            
            i = 0;
            sum = 0;
            for(; i <N; i++)
            {
                if(i % 2 != 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine(sum);

            while (true)
            {
                sum += i % 2 == 0 ? i : 0;

                if (++i >= N)
                {
                    break;
                }
            }
            Console.WriteLine(sum);

            string messege = Console.ReadLine();
            if(int.TryParse(messege,out int digit))
            {
                Console.WriteLine(digit);
            }
            else
            {
                Console.WriteLine($"Input is incorrect");
            }

            //16 - 0001 0000
            Console.WriteLine(16 >> 64);//Вернёт 16, сделает большой круг

            //a і b ввод с клавиатуры 
            //v вариант
            // 1 - добавляем 
            // 2 - отнимаем 
            // 3 - умножения 
            // 4 - деления  
            // всё другое не цыфри - выход с программы  

            Console.WriteLine("Please enter two numbers and various");
            Console.WriteLine("Please enter first number:");
            var firstNum = Console.ReadLine();
            Console.WriteLine("Please enter first number:");
            var secondNum = Console.ReadLine();
            Console.WriteLine("Please enter varius:");
            var variant = Console.ReadLine();

            var aA = Convert.ToInt32(firstNum);
            var bB = Convert.ToInt32(secondNum);
            var Variant = Convert.ToInt32(variant);

            switch (Variant)
            {
                case 1:
                    Console.WriteLine($"Sum {aA + bB}");
                    break;
                case 2:
                    Console.WriteLine($"Subtsract {aA - bB}");
                    break;
                case 3:
                    Console.WriteLine($"Mult {aA * bB}");
                    break;
                case 4:
                    Console.WriteLine($"Divide {aA / bB}");
                    break;

                default:
                    Console.ReadKey();
                    break;
            }
        }
    }
}
