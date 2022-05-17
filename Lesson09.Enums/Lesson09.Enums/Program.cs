using System;

namespace Lesson09.Enums
{
    enum DayOfWeek
    {
        Sunday = -15,
        Monday,
        Tuesday
    }

    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek dayOfWeek = DayOfWeek.Monday;
            foreach (var item in Enum.GetValues<DayOfWeek>())
            {
                Console.WriteLine((int)item);
            }

            DayOfWeek newDayOfWeek = (DayOfWeek)2;
            Console.WriteLine($"Today is {(DayOfWeek)2}");
            Console.WriteLine($"Today{dayOfWeek} is {GetHoliday(dayOfWeek)}");
        }

        private static string GetHoliday(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                    return "non-holiday";
                case DayOfWeek.Sunday:
                    return "holiday";
            }
            return string.Empty;
        }
    }
}
