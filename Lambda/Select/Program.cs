using System;
using System.Collections.Generic;
using System.Linq;

namespace Select
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> {"Pranav", "Hrituj", "Nitesh", "Pramod" };

            Console.WriteLine("Names in UpperCase : ");
            var upperNames = names.Select(n => n.ToUpper());
            //var lowerNames = names.Select(n => n.ToLower());
            foreach (var name in upperNames)
            {
                Console.WriteLine(name);
            }

          
        }
    }
}
