using System;
using System.Collections.Generic;
using System.Linq;

namespace Join
{
    internal class Salary
    {
        public int PersonId { get; set; }
        public int Amount { get; set; }
    }
    internal class Person
    {


        public int Id { get; private set; }
        public string Name { get; private set; }

        static void Main(string[] args, Salary salary)
        {
            List<Person> people = new List<Person>
            {
                new Person {Id = 1, Name = "Alice"},
                new Person {Id = 2, Name = "Bob"},
                new Person {Id = 3, Name = "Catty"},
            };

            List<Salary> salaries = new List<Salary>
            {
                new Salary{PersonId = 1, Amount = 5000},
                new Salary{PersonId = 2, Amount = 6500},
                new Salary{PersonId = 3, Amount = 3700},
            };

            //...Join People and Salaries based on PersonId
            var joinData = people.Join(
                salaries,
                person => person.Id,
                salaries => salary.PersonId,
                (person, salary) => new { person.Name, salary.Amount });
        }
    }

   
}
