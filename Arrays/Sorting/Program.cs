using System;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[6] { "A", "C", "M", "R", "Y", "F" };

            Console.WriteLine("Original Array : ");
            foreach (string s in arr)
            {
                Console.Write(s+" ");
            }

            Console.WriteLine("\nAfter Sorting : ");
            Array.Sort(arr);

            foreach (string s in arr)
            {
                Console.Write(s+" ");
            }

            Console.WriteLine("\nD sorts between : ");
            int index = Array.BinarySearch(arr, "D");

            sortT(arr, index);

            Console.WriteLine("\nQ sorts between : ");
            index = Array.BinarySearch(arr, "Q");
            sortT(arr, index);
        }

        private static void sortT<T>(T[] arr, int index)
        {
            if(index < 0)
            {
                index = ~index;

                if(index == 0)
                    Console.WriteLine("Begining of array");
                else
                    Console.WriteLine("{0} and ", arr[index - 1]);

                if(index == arr.Length)
                    Console.WriteLine("End of array.");
                else
                    Console.WriteLine("{0}", arr[index]);

            }
        }
    }
}
