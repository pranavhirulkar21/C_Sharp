using System;
using System.Collections;

namespace Operations
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

            foreach (var itam in que)
            {
                Console.WriteLine(itam);
            }

            //Console.WriteLine("Total no. of Elements in the Queue are : " + que.Count);

            //Console.WriteLine("Removal the elements from the queue : "+que.Dequeue());

            Console.WriteLine("Total no. of Elements in the Queue are : " + que.Count);

            Console.WriteLine("que is {0}.", que.IsSynchronized ? "synchronized" : "Not synchronized");

            Queue sque = Queue.Synchronized(que);

            Console.WriteLine("sque is {0}", sque.IsSynchronized ? "synchronized" : "Not synchronized");
            Console.WriteLine(que.IsSynchronized);
            Console.WriteLine(sque.IsSynchronized);

            //Console.WriteLine("Deletion of all the elements from the Queue : ");
            //que.Clear();
            //Console.WriteLine("Total no. of Elements in the Queue are : " + que.Count);

            Console.WriteLine();

            //Clone method
            Console.WriteLine("Cloned Queue : ");
            Queue cque = (Queue)que.Clone();
            foreach (var item in cque) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Contains method
            Console.WriteLine("Checking if element present or not : "+que.Contains("abcd"));
            Console.WriteLine();

            //CopyTo method, replaces the respective elements of rray with queue elements
            string[] arr = new string[7];

            arr[0] = "1st Element";
            arr[1] = "2nd Element";
            arr[2] = "3rd Element";
            arr[3] = "4th Element";
            arr[4] = "5th Element";
            arr[5] = "6th Element";
            arr[6] = "7th Element";

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            que.CopyTo(arr, 2);  //2 elements are replaced

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //ToArray method, copies the Queue elements to a new array.
            Console.WriteLine("Printing the array which is crated from queue elements : ");
            Object[] arry = que.ToArray();
            foreach (var item in arry)
            {
                Console.WriteLine(item);
            }
        }
    }
}
