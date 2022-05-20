using System;
using System.Text;
using System.Collections.Generic;

namespace Lesson07.Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Serhii";
            string hisName = "Nick";
            string placeholder = "Hello, {0} and {1}";

            Console.WriteLine($"Hello, {name}");
            Console.WriteLine($"Hello, {name}, {hisName}");
            Console.WriteLine(string.Format("Hello, {0}, {1}", name, hisName));

            var hello = $"Hello, {name}, {hisName}";
            char symbol = hello[5];
            Console.WriteLine(symbol);

            for (int i = 0; i < hello.Length; i++)
            {
                Console.WriteLine(hello[i]);
            }
            Console.WriteLine();

            Console.WriteLine(char.IsDigit(symbol));        //false
            Console.WriteLine(char.IsLetter(symbol));       //false
            Console.WriteLine(char.IsLower(symbol));        //false
            Console.WriteLine(char.IsPunctuation(symbol));  //true
            Console.WriteLine(char.ToUpper('a'));           //A
            Console.WriteLine(char.ToUpper(','));           //,

            Console.WriteLine(string.Concat("string", "  ", "string"));
            Console.WriteLine(hello.Contains('H'));
            Console.WriteLine(hello.Contains("H"));
            Console.WriteLine(hello.Contains('s', StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine(hello.Insert(0, "Some inserted string "));
            Console.WriteLine(hello.Insert(7, "Alex, "));
            Console.WriteLine(hello.Remove(7));             //удаляет с какого-то регистра
            Console.WriteLine(hello.Remove(7, 2));
            Console.WriteLine(hello.Replace(name, hisName));
            Console.WriteLine(hello.ToUpperInvariant());
            Console.WriteLine(hello.ToLowerInvariant());
            Console.WriteLine($"          {name}        ".Trim());

            foreach (var item in hello.Split('i'))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(1.CompareTo(2));  //-1
            Console.WriteLine(2.CompareTo(2));  //0
            Console.WriteLine(3.CompareTo(2));  //1

            Console.WriteLine(string.Equals("abc", "abc"));     //true
            Console.WriteLine(string.Equals("abc", "bcd"));     //false
            Console.WriteLine(string.Compare("abc", "abc"));    //0
            Console.WriteLine(string.Compare("abc", "bcd"));    //-1
            Console.WriteLine(string.Compare("pbc", "abc"));    //1
            Console.WriteLine(string.Compare("abcd", "abc"));    //1

            var emptyString = string.Empty;
            const int N = 1000;
            for (int i = 0; i < N; i++)
            {
                emptyString += $"{i} ";
            }

            var stringBuilder = new StringBuilder();

            for (int j = 0; j < N; j++)
            {
                stringBuilder.AppendFormat("{0} ", j);
            }
            Console.WriteLine(emptyString);
            Console.WriteLine(stringBuilder.ToString());

            //abcbcd => ["b", "c"]
            //Compare
            Console.WriteLine("Please enter first string: ");
            string first = Console.ReadLine();
            Console.WriteLine($"Your string is: {first}");
            Console.WriteLine("Please enter second string: ");
            string second = Console.ReadLine();
            Console.WriteLine($"Your string is {second}");
            Console.WriteLine($"Method Compare is: {Compare(first, second)}");
            //Analyze 
            Console.WriteLine($"{Environment.NewLine}Please enter string: ");
            first = Console.ReadLine();
            Console.WriteLine($"Your string is: {first} {Environment.NewLine} Method Analyze is: {Analyze(first)}");
            //Sort

            Console.WriteLine($"{Environment.NewLine}Please enter string for sorting: ");
            first = Console.ReadLine();
            Console.WriteLine($"Your string is: {first} {Environment.NewLine}Method Sort is: {Sort(first)}");

            //Duplicate
            Console.WriteLine($"{Environment.NewLine}Please enter string for duplicate: ");
            first = Console.ReadLine();
            string result = Duplicate(first);
            Console.WriteLine($"Result method Duplicate is: {result}");
        }

        private void Print(string placeholder, string name)
        {
            Console.WriteLine(string.Format(placeholder, name));
            Console.WriteLine($"Hello, {name}");
        }

        //homework
        private static bool Compare(string first, string second)
        {
            bool result = false;
            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < second.Length; j++)
                {
                    if (first.Length == second.Length && first[i] == second[j])
                        result = true;
                    else if (first.Length != second.Length && first[i] != second[j])
                    {
                        result = false;
                    }
                }
            }
            return result;
        }

        private static int Analyze(string first)
        {
            return first.Length;
        }

        private static string Sort(string first)
        {
            char[] chars = first.ToCharArray();
            for (int i = 1; i < chars.Length; i++)
            {
                for (int j = 0; j < chars.Length - 1; j++)
                {
                    if (chars[j] > chars[j + 1])
                    {
                        var temp = chars[j];
                        chars[j] = chars[j + 1];
                        chars[j + 1] = temp;
                    }
                }
            }
            string result = new(chars);
            return result;
        }

        private static string Duplicate(string first)
        {
            char[] chars = first.ToCharArray();
            string temp = String.Empty;
            for (int i = 0; i < chars.Length - 1; i++)
            {
                bool charExixts = false;
                for (int j = i + 1; j < chars.Length; j++)
                {
                    if (!charExixts && !temp.Contains(chars[i]))
                    {
                        charExixts = true;
                        temp += chars[i];
                    }
                }
            }
            return temp;
        }


    }
}
