using System;
using System.Collections.Generic;
using System.Linq;

namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Johny", "Bob", "Dolly", "Cally", "Jell"};

            //...ToList : Convert to a List<string>
            List<string> nameList = names.ToList();

            //...ToArray : Convert to an Array of strings
            string[] nameArray = names.ToArray();

            //...ToDictionay : Convert to a Dictionary with names as keys
            Dictionary<string, int> nameDictionay = names.ToDictionary(name => name, name => name.Length);

            foreach(var pair in nameDictionay)
            {
                Console.WriteLine($"Key : {pair.Key}, Value : {pair.Value}");
            }

        }
    }
}
