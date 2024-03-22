using System;
using System.Collections;

namespace Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hasht = new Hashtable();

            hasht.Add(1, "C#");
            hasht.Add(2, "Java");
            hasht.Add(3, "Python");
            hasht.Add(4, "C++");
            hasht.Add(5, "Kotlin");
            hasht.Add(6, "Rust");

            ICollection key = hasht.Keys;

            Console.WriteLine("HashTable Contains : ");
            Console.WriteLine();
            foreach(var val in key)
            {
                Console.WriteLine(val+" - " + hasht[val]);
            }

        }
    }
}
