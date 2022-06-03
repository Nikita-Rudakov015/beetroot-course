using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.IntroToOOP
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Person()
        {

        }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FullName()
        {
            return $"{this.FirstName} {LastName}";
        }

        public string FullInfo()
        {
            return $"{this.FullName()}, {this.Age} years old";
        }

        public static Person Create(string firstName, string lastName, int age)
        {
            Person person = new Person();
            person.FirstName = firstName;
            person.LastName = lastName;
            person.Age = age;

            return person;
        }
    }
}
