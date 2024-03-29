using System;
using System.Collections.Generic;
using System.Linq;

namespace Paging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> fruits = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

            int pageSize = 2;
            int pageNumber = 2;

            //...Skip : Skip elements based on page size and numberr
            var pagedFruits = fruits.Skip((pageNumber-1) * pageSize).Take(pageSize);


            foreach ( var i in pagedFruits)
            {
                Console.WriteLine(i);
            }


        }
    }
}
