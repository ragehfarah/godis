using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godiskalkylatorn
{
    internal class Person
    {
        List<Person> Persons = new List<Person>();
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Candies { get; set; }
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Candies;
        }

    }



}
