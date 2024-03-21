using System;
using System.Collections;

namespace Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push("1st Element");
            stack.Push("2nd Element");
            stack.Push("3rd Element");
            stack.Push("4th Element");
            stack.Push("5th Element");
            stack.Push("6th Element");
            stack.Push("7th Element");

            Console.WriteLine("Elements in the Stack are : ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
