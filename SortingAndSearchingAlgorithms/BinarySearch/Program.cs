using System;
/*
namespace BinarySearch
{
    internal class BinarySearch
    {
        static void display(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        public int binarySearch(int[] array, int x, int low, int high)
        {
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == x)
                    return mid;

                if (array[mid] < x)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            BinarySearch bs = new BinarySearch();
            int[] numbers = { 2, 5, 8, 4, 6, 3, 7, 1, 9 };

            Console.WriteLine("Original Array : ");
            display(numbers);

            Console.WriteLine("Enter the Number You wanna find : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int n = numbers.Length;

            int result = bs.binarySearch(numbers, x, 0, n - 1);

            if (result == -1)
                Console.WriteLine("Not found");
            else
                Console.WriteLine("Element found at index " + result);

        } 
    }
}
*/



namespace BinarySearch
{
    internal class BinarySearch
    {
        static void display(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }

        public int binarySearch(int[] array, int x, int low, int high)
        {
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == x)
                    return mid;

                if (array[mid] < x)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            return -1;
        }

        public static void Main(string[] args)
        {
            BinarySearch bs = new BinarySearch();
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] numbers = { 2, 5, 8, 4, 6, 3, 7, 1, 9 };

            Console.WriteLine("Original Array : ");
            display(numbers);

            Array.Sort(numbers); // Sort the array

            Console.WriteLine("Sorted Array : ");
            display(numbers);


            Console.WriteLine("Enter the Number You want to find : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int n = numbers.Length;

            int result = bs.binarySearch(numbers, x, 0, n - 1);

            if (result == -1)
                Console.WriteLine("Not found");
            else
                Console.WriteLine("Element found at index " + result);

        }
    }
}


