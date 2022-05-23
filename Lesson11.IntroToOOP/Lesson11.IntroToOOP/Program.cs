using System;

namespace Lesson11.IntroToOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Serhii";
            person.LastName = "Olefir";
            person.Age = 12;

            var anotherPerson = new Person("Andrew", "Demchuk", 40);
            var thirdPerson = Person.Create("Lev", "Tolstoy", 200);

            var fourhPerson = new Person
            {
                FirstName = "Nick",
                LastName = "Someone",
                Age = 30
            };

            Print(person);
            Print(anotherPerson);
            Print(thirdPerson);
            Print(fourhPerson);

            var records = new PhoneBookRecord[]
            {
                new PhoneBookRecord(person, 125),
                new PhoneBookRecord(anotherPerson, 456),
                new PhoneBookRecord(thirdPerson, 789),
                new PhoneBookRecord(fourhPerson, 000)
            };
            var phoneBook = new PhoneBook(records);
            foreach(var item in phoneBook.Records)
            {
                Console.WriteLine(item.FullInfo());
            }

        }

        private static void Print(Person person)
        {
            Console.WriteLine($"{person.FullInfo()}");
        }
    }
}
