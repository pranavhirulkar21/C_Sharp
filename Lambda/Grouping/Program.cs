using System;
using System.Collections.Generic;
using System.Linq;

namespace Grouping
{
    internal class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "John", Age = 30 },
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 },
                new Person { Name = "Eve", Age = 25 }
            };

            //...Group People by Age
            var groupPeopleByAge = people.GroupBy(x => x.Age);

            foreach (var element in groupPeopleByAge)
            {
                Console.WriteLine($"Age: {element.Key}");
                foreach (var person in element) 
                {
                    Console.WriteLine($" - {person.Name}");
                }
            }


        }
    }
}
