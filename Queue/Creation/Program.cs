using System;
using System.Collections;

namespace Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();

            que.Enqueue("1st Item");
            que.Enqueue("2nd Item");
            que.Enqueue("3rd Item");
            que.Enqueue("4th Item");
            que.Enqueue("5th Item");
            que.Enqueue("6th Item");
            que.Enqueue("7th Item");

            Console.WriteLine("The Elements of Queue are : ");
            foreach (var item in que)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Total no. of Elements in the Queue are : "+que.Count);
        }
    }
}
