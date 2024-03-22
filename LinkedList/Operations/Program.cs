using System;
using System.Collections.Generic;

namespace Operations
{
    internal class Program
    {
        public static void displayList(LinkedList<String> list)
        { Console.WriteLine("The Nodes in LinkedList : ");
            foreach(String str in list) { Console.WriteLine(str); }
            Console.WriteLine();
        }

        public static void lastNode(LinkedList<String> list)
        {
            if(list.Count > 0) { Console.WriteLine("The Last Node is "+list.Last.Value); } 
            else { Console.WriteLine("List is Empty !!!"); }
            Console.WriteLine();
        }

        public static void firstNode(LinkedList<String> list)
        {
            if(list.Count > 0) { Console.WriteLine("The First Node is " + list.First.Value); }
            else { Console.WriteLine("The Lst is Empty !!!"); }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            LinkedList<string> listt = new LinkedList<string>();

            list.AddLast("India");
            list.AddLast("USA");
            list.AddLast("Russia");
            list.AddLast("China");

            list.AddFirst("Britain");
            list.AddFirst("Uganda");
            list.AddFirst("Maxico");

            displayList(list);

            Console.WriteLine("Total Number of Nodes in LinkedList : "+list.Count);
            Console.WriteLine();

            //...TO GET THE LAST NODE IN LINKEDLIST
            lastNode(list);

            //...TO GET THE FIRST NODE IN LINKEDLIST
            firstNode(list);

            //...TO REMOVE THE FIRST NODE IN LINKEDLIST
            //list.RemoveFirst();
            //displayList(list);

            //...TO REMOVE THE LAST NODE IN LINKEDLIST
            //list.RemoveLast();
            //displayList(list);

            //...TO REMOVE ALL THE NODES FROM LINKEDLIST
            //list.Clear();
            //displayList(list);

            //...TO REMOVE A SPECIFIC NODE IN LINKEDLIST
            //...list.remove("Value");
            //list.Remove("India");
            //displayList(list);

            //...TO CHECK WHETHER A NODE/VALUE IS PRESENT IN LIST OR NOT
            Console.WriteLine(list.Contains("India"));
            Console.WriteLine();

            //...TO CHECK WHETHER THE LIST IS EQUAL TO ANOTHER LIST OR NOT
            Console.WriteLine(list.Equals(list));
            Console.WriteLine();

            //...COPY THE ENTIRE LINKEDLIST TO ARRAY
            String[] Arr = new string[50]; //just taking 50 as large value bcoz array is static and linkedlist is dynamic
            list.CopyTo(Arr, 0);
            foreach(String s in Arr) { Console.WriteLine(s); }

            //...ENUMERATOR
            LinkedList<String>.Enumerator enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                String val = enumerator.Current;
                Console.WriteLine(val);
            }


        }
    }
}
