using System;

namespace BubbleSort
{
    internal class Program
    {
        static void display(int[] arr)
        {
            foreach(int i in arr)
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


            //...BUBBLE SORT ALGORITHM
            for(int i = 0; i < numbers.Length-1; i++)
            {
                for(int j = 0; j < numbers.Length-i-1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j+1];
                        numbers[j+1] = temp;
                    }
                }
            }

            Console.WriteLine("Bubble Sorted Array : ");
            display(numbers);
        }
    }
}
