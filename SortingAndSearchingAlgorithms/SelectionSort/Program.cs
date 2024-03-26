using System;

namespace SelectionSort
{
    internal class Program
    {
        static void display(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 8, 4, 6, 3, 7, 1, 9 };

            Console.WriteLine("Original Array : ");
            display(numbers);

            //...SELECTION SORT ALGORITHM

            int temp, min_key;
            for(int i = 0; i < numbers.Length-1;  i++)
            {
                min_key = i;
                for(int j = i+1;  j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[min_key])
                    {
                        min_key = j;
                    }
                }
                temp = numbers[min_key];
                numbers[min_key] = numbers[i];
                numbers[i] = temp;
            }

            Console.WriteLine("Selection Sorted Array : ");
            display(numbers);

        }
    }
}
