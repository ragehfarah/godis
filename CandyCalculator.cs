using Godiskalkylatorn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godiskalkylatorn
{
    internal class CandyCalculator
    {
        List<Person> persons = new List<Person>();

        public List<Person> Persons { get { return persons; } }
      

        public void Addperson(string firstName, string lastName, int age)
        {
            persons.Add(new Person(firstName, lastName, age));
        }

        public void AgeSort()
        {
            
           
                persons = persons.OrderBy(x => x.Age).ToList();
            }
          public void FirstNameSort()
            {
                persons = persons.OrderBy(x => x.FirstName).ToList();
            }
           public void LastNameSort()
            {
                persons = persons.OrderBy(x => x.LastName).ToList();
            }
        public void DistributeCandy(int totalCandies)
        {
            int candyPerPerson = totalCandies / persons.Count;
            foreach (Person person in persons)
            {
                person.Candies = candyPerPerson;

            }
        }

        
         
        }


    }


