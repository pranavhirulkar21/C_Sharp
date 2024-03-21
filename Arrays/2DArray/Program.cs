using System;

namespace _2DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] Arr = new int[2][];
            //int[,] Arr = new int[2, 0];   Both initialization are same!

            Arr[0] = new int[4] { 2, 4, 3, 5 };
            Arr[1] = new int[3] { 1, 8, 6 };

            int[][] Arr1 = { new int[] { 2, 4, 3, 5 },
                             new int[] { 1, 8, 6 } };
            // Both the ways of creting Arr and Arr1 are correct!!!!
            
            for(int i=0; i<Arr.Length; i++)
            {
                Console.WriteLine("Element ["+i+"] Array: ");
                for(int j = 0; j < Arr[i].Length; j++)
                {
                    Console.WriteLine(Arr[i][j]+" ");

                    
                    // int[,] arr = new int[, ]
                     
                }
        
            /*
            for(int i = 0; i < Arr.GetLength(0); i++) {
                Console.Write("\n Row #{0} Elements :", (i+1));
                for(int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write("{0}\t", (i, j));
                }
            }
            */

            }

        }
    }
}
