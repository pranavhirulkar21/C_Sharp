using System;

namespace _3_2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][,] arr = new int[3][,] {new int[, ] {{1, 3}, {5, 7}},
                                          new int[, ] {{0, 2}, {4, 6}, {8, 10}},
                                          new int[, ] {{11, 22}, {99, 88}, {0, 9}}};

            
            for (int i = 0; i < arr.Length; i++)
            {
                int x = 0;
                for (int j = 0; j < arr[i].GetLength(x); j++)
                {
                    for (int k = 0; k < arr[j].Rank; k++)
                        Console.Write(" arr[" + i + "][" + j + ", " + k + "]:"
                                                       + arr[i][j, k] + " ");
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }
    }
}
