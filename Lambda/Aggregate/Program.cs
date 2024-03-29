using System;
using System.Collections.Generic;
using System.Linq;

namespace Aggregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7};

            //...Calculate sum of numbers

            int sum = num.Aggregate((acc, num) => acc + num);

            Console.WriteLine($"Sum : {sum}");

        }
    }
}
