using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] cars = { "BMW", "AUDI", "MAZDA", "TOYOTA", "TATA", "MUSTANG" };
            int[] numbers = { 1, 5, 3, 6, 7, 4, 8 };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write(cars[i]+" ");
            }
            Console.WriteLine();

            foreach (int i in numbers)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            Console.WriteLine(cars.Length);
            Console.WriteLine(numbers.Length);
            */

            int[,] numbers = { { 1, 4, 2, }, { 3, 5, 6, } };
            
            for(int i = 0; i < numbers.GetLength(0); i++)
            {
                for(int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }


        }
    }
}
