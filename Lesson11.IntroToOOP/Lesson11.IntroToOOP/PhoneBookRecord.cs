using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.IntroToOOP
{
    public class PhoneBookRecord
    {
        public Person Person;
        public int Number;

        public PhoneBookRecord(Person person, int number)
        {
            this.Person = person;
            this.Number = number;
        }

        public string FullInfo()
        {
            return $"{this.Person.FullInfo()} with phone number {this.Number}";
        }
    }
}
