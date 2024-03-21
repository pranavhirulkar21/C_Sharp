using System;
using System.Collections;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stackk = new Stack();

            stackk.Push("1st Element");
            stackk.Push("2nd Element");
            stackk.Push("3rd Element");
            stackk.Push("4th Element");
            stackk.Push("5th Element");
            stackk.Push("6th Element");
            stackk.Push("7th Element");

            Console.WriteLine("The type of stackk: " + stackk.GetType()); //ToString is used to convert the stack type to string type

            Console.Write("Total no. of elements in stck are : "+ stackk.Count);
            Console.WriteLine();

            Console.WriteLine("\nElement at the top is: "+ stackk.Peek());

            //Console.WriteLine("\nRemoval of top most element : "+stack.Pop());

           //Console.WriteLine("\nDeletion of all element from stack : ");
           //stack.Clear();

            Console.Write("\nTotal no. of elements in stck are : " + stackk.Count);

            //      CLONE METHOD
            //Stack test = new Stack();
            //test = (Stack)stackk.Clone();

            //foreach (var item in test) {
            //    Console.WriteLine(item);
            //}

            Console.WriteLine();
            Console.WriteLine("Check whether a \"3rd Element\" present in stack or not : " + stackk.Contains("3rd Element"));

            //IsSynchronized method
            Console.WriteLine("stackk is {0}.", stackk.IsSynchronized ? "Synchronized" : "Not Synchronised");

            Stack newStackk = Stack.Synchronized(stackk);  //to make stack synchronized

            Console.WriteLine("newStackk is {0}.", newStackk.IsSynchronized ? "Synchronized" : "Not Synchronised");

            // CopyTo method
            string[] str = new string[stackk.Count];
            stackk.CopyTo(str, 0);
            foreach (string str2 in str) {
                Console.WriteLine(str2);
            }
            Console.WriteLine();

            //ToArray method
            Console.WriteLine("ToArray method : ");
            Object[] arry = stackk.ToArray();
            foreach (Object arry2 in arry) {
                Console.WriteLine(arry2);
            }

            //Equals method
            Stack sta = new Stack();
            sta.Push(1);
            sta.Push(3);
            sta.Push(7);

            Console.WriteLine("Checking if two stacks are equal or not : "+stackk.Equals(sta));
        }
    }
}
