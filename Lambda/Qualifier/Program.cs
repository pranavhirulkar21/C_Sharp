using System;
using System.Collections.Generic;
using System.Linq;

namespace Qualifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6 };

            //..Check if any number is divisible by 7
            bool anyDivisibleBy7 = num.Any(n => n % 7 == 0);
            Console.WriteLine($"Any number divisible by 7? {anyDivisibleBy7}");

            bool anyDivisibleBy3 = num.Any(n => n%3 == 0);
            Console.WriteLine($"Any number divisible by 3? {anyDivisibleBy3}");


        }
    }
}
