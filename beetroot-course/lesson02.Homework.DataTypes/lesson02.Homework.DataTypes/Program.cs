using System;

namespace lesson02.Homework.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10;
            Console.WriteLine($"The first task: {-6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15}");
            Console.WriteLine($"The second task: {Math.Abs(x) * Math.Sin(x)}");
            Console.WriteLine($"The third task: {2 * Math.PI * x}");
            Console.WriteLine($"The fourth task: {Math.Max(x, y)}");

            var dateToday = new DateTime(2022, 4, 30, 21, 05, 52);
            Console.WriteLine("\n Today " + dateToday.ToString("F"));

            //Extra
            System.DateTime date1 = new System.DateTime(2022, 4, 30, 21, 05, 52);
            System.DateTime date2 = new System.DateTime(2023, 1, 1, 00, 00, 0);
            System.DateTime date3 = new System.DateTime(2021, 1, 1, 00, 00, 0);
            System.TimeSpan diff1 = date2 - date1;
            System.TimeSpan diff2 = date1 - date3;
            Console.WriteLine($"How many days until The New Year 2023:  {diff1}");
            Console.WriteLine($"How many days passed since The New Year 2021:  {diff2}");

        }
    }
}
