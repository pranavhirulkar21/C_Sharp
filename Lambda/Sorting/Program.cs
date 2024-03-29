using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string> { "pineapple", "date", "banana", "apple", "cherry", "mango" };

            Console.WriteLine("Original Order of Fruits : ");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();



            //...Sorting the Fruits in Ascending order
            var sortedFruits = fruits.OrderBy(fruits => fruits);
            Console.WriteLine("Fruits in Sorted Order : ");
            foreach (var item in sortedFruits)
            {
                Console.WriteLine(item);
            }
        }
    }
}
