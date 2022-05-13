using System;
using System.Text;

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

            foreach(var item in hello.Split('i'))
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
            for(int i = 0; i < N; i++)
            {
                emptyString += $"{i} ";
            }

            var stringBuilder = new StringBuilder();

            for(int j = 0;j < N; j++)
            {
                stringBuilder.AppendFormat("{0} ", j);
            }
            Console.WriteLine(emptyString);
            Console.WriteLine(stringBuilder.ToString());

            //abcbcd => ["b", "c"]
        }

        private void Print(string placeholder, string name)
        {
            Console.WriteLine(string.Format(placeholder, name));
            Console.WriteLine($"Hello, {name}");
        }
    }
}
