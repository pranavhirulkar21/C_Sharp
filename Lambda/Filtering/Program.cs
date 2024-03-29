using System;
using System.Collections.Generic;
using System.Linq;

namespace Filtering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //...filter the even numbers
            var even = numbers.Where(n => n%2 == 0);

            Console.Write("The Even Numbers are : ");
            foreach (int num in even)
            {
                Console.Write(num+" ");
            }

            var odd = numbers.Where(n => n%2 != 0);

            Console.Write("\nThe Odd Numbers are : ");
            foreach(int num in odd)
            {
                Console.Write(num+" ");
            }
        }
    }
}
