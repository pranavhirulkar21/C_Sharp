using System;
using System.Collections.Generic;
using System.Linq;

namespace Retrieval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8};

            //...Get the First Even Number
            int firstEven = numbers.First(n => n%2 == 0);
            Console.WriteLine($"First Even Number : {firstEven}");

            //...Get the Last Even Number
            int lastEven = numbers.Last(n => n%2 == 0);
            Console.WriteLine($"Last Even Number : {lastEven}");

            //...Get the First Odd Number
            int firstOdd = numbers.First(n => n%2 != 0);
            Console.WriteLine($"First Odd Number : {firstOdd}");

            //...Get the Last Odd Number
            int lastOdd = numbers.Last(n => n%2 != 0);
            Console.WriteLine($"Last Odd Number : {lastOdd}");
        }
    }
}
