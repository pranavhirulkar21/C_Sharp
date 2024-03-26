using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<String> list = new LinkedList<String>();

            list.AddLast("India");
            list.AddLast("USA");
            list.AddLast("Russia");
            list.AddLast("France");
            list.AddLast("Britain");
            list.AddLast("Canada");
            list.AddLast("Brazil");

            list.AddFirst("Uganda");
            list.AddFirst("Maxico");


            foreach(String str in list)
            {
                Console.WriteLine(str);
            }

        }
    }
}
