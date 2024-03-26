using System;

namespace LinearSearch
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

        private static int LinearSearch(int[] numbers, int x)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == x)
                    return i;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 8, 4, 6, 3, 7, 1, 9 };

            Console.WriteLine("Original Array : ");
            display(numbers);

            Console.WriteLine("Enter the number you wanna find : ");
            int x = Convert.ToInt32(Console.ReadLine());

            int result = LinearSearch(numbers, x);

            if(result == -1)
                Console.WriteLine("Element not found");
            else
                Console.WriteLine("Element found at index : "+result);
            

        }
    }
}
