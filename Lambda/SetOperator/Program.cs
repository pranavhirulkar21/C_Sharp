using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5};
            List<int> numbers2 = new List<int> { 4, 5, 6, 7, 8};

            //...Union : Get the distinct numbers from both lists
            var union = numbers1.Union(numbers2);

            Console.WriteLine("Union: ");
            foreach (int i in union) Console.WriteLine(i);


            //...Intersect : Get the common numbers from both lists
            var interset = numbers1.Intersect(numbers2);

            Console.WriteLine("\nIntersect : ");
            foreach(int i in interset) Console.WriteLine(i);


            // Except: Get the numbers in numbers1 that are not present in numbers2
            var except = numbers1.Except(numbers2);

            Console.WriteLine("\nExcept:");
            foreach (int i in except) Console.WriteLine(i);



        }
    }
}
