using System;

namespace InsertionSort
{
    internal class Program
    {
        static void display(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 8, 4, 6, 3, 7, 1, 9 };

            Console.WriteLine("Original Array : ");
            display(numbers);

            int val, flag;
            //... INSERTION SORT ALGORITHM
            for(int i = 1; i < numbers.Length; i++)
            {
                val = numbers[i];
                flag = 0;

                for(int j = i-1; j >= 0 && flag != 1;)
                {
                    if (val < numbers[j])
                    {
                        numbers[j + 1] = numbers[j];
                        j--;
                        numbers[j + 1] = val;
                    }
                    else
                        flag = 1;
                }
            }
            Console.WriteLine("Insertion Sorted Array : ");
            display(numbers);

        }
    }
}
