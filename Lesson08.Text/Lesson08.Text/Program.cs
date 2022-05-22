using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Lesson08.Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Phone book.csv";

            string[] content = File.ReadAllLines(filePath);

            // (int a, int b) tuple;
            //
            // tuple.b = 3;
            // tuple.a = 1;
            // int c = tuple.a + tuple.b;

            foreach (var item in content)
            {
                Console.WriteLine(item);
            }

            foreach ((string name, int number) item in Deserialize(content))
            {
                Console.WriteLine($"Name is {item.name}, number is {item.number}");
            }

            var phoneBook = Deserialize(content);
            int right = phoneBook.Length;
            Console.WriteLine("Please enter name for binary searching");
            string findName = Console.ReadLine();
            Console.WriteLine("Please enter number for binary searching");
            string findNumber = Console.ReadLine();
            int findNum = Convert.ToInt32(findNumber);
            /*var newRecord = (name: "Jacob", number: 1212);
            Add(ref phoneBook, newRecord);
            Update(phoneBook, newRecord, 0);*/
            Array.Sort(phoneBook);           
            BinarySearchName(phoneBook, findName);
            SortSelectionAscNumber(phoneBook);
            int result = BinarySearchNumber(phoneBook, 0, right - 1, findNum);
            if (result == -1)
            {
                Console.WriteLine("Element not present");
            }
            else
            {
                Console.WriteLine($"Element {findNumber} found at index: {result}");
            }
            var serializedBook = Serialize(phoneBook);
            foreach (var item in serializedBook)
            {
                Console.WriteLine(item);
            }

            File.WriteAllLines(filePath, serializedBook);
        }

        private static int BinarySearchName((string name, int number)[] content, string searchTerm)
        {
            var phoneBook = content;
            int first = 0;
            int last = phoneBook.Length - 1;
            int position = -1;
            bool found = false;
            int compCount = 0;

            while (found != true && first <= last)
            {
                int middle = first + (last - first) / 2;

                if (string.Compare(phoneBook[middle].name, searchTerm, true) == 0)
                {
                    found = true;
                    position = middle;
                    compCount++;

                    Console.WriteLine($"Your search has been found {searchTerm} after {compCount} comparisons.");
                }
                else if (string.Compare(phoneBook[middle].name, searchTerm, true) > 0)
                {
                    last = middle;
                    compCount++;
                }
                else
                {
                    first = middle;
                    compCount++;
                }
            }
            return position;
        }

        private static int BinarySearchNumber((string name, int number)[] content, int left, int right, int findNumber)
        {
            var phoneBook = content;
            if (right >= left)
            {
                int middle = left + (right - left) / 2;

                // If the element is present at the
                // middle itself
                if (phoneBook[middle].number == findNumber)
                    return middle;

                // If element is smaller than mid, then
                // it can only be present in left subarray
                if (phoneBook[middle].number > findNumber)
                    return BinarySearchNumber(phoneBook, left, middle - 1, findNumber);

                // Else the element can only be present
                // in right subarray
                return BinarySearchNumber(phoneBook, middle + 1, right, findNumber);
            }

            // We reach here when element is not present
            // in array
            return -1;
        }

        private static void SortSelectionAscNumber((string name, int number)[] content)
        {
            for (int i = 0; i < content.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < content.Length; j++)
                {
                    if (content[j].number < content[minIndex].number)
                    {
                        minIndex = j;
                    }
                }

                int temp = content[minIndex].number;
                content[minIndex].number = content[i].number;
                content[i].number = temp;
            }

        }

        private static void Update((string name, int number)[] content, (string name, int number) updatedItem, int index)
        {
            content[index] = updatedItem;
        }

        private static void Delete(ref(string name, int number)[] content, int index)
        {
            var newBook = new (string name, int number)[content.Length - 1];
            int j = 0;
            for(int i = 0; i < content.Length; i++)
            {
                if(i != index)
                {
                    newBook[j++] = content[i];
                }
            }
            content = newBook;
        }

        private static void Add(ref(string name, int number)[] content, (string name, int number)  newItem)
        {
            var newBook = new (string name, int number)[content.Length + 1];
            content.CopyTo(newBook, 0);
            newBook[content.Length] = newItem;
            content = newBook;
        }

        private static string[] Serialize((string name, int number)[] content)
        {
            var strings = new string[content.Length];
            for (int i = 0; i < content.Length; i++)
            {
                strings[i] = $"{content[i].name};{content[i].number}";
            }

            return strings;
        }

        private static (string name, int number)[] Deserialize(string[] content)
        {
            var regexp = new Regex(@"^(\w+);(\d+)$");
            var book = new (string name, int number)[content.Length];
            for (int i = 0; i < content.Length; i++)
            {
                var item = content[i];
                var match = regexp.Match(item);

                if (match.Success)
                {
                    book[i].name = match.Groups[1].Value;
                    book[i].number = int.Parse(match.Groups[2].Value);
                }
            }
            return book;
        }
    }
}
