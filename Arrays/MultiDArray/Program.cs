using System;

namespace MultiDArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Arr = new int[, ] { { 3, 4 },
                                       { 5, 3 },
                                       { 6, 8 },
                                       { 7, 1 } };

            int[,] Arr_d = new int[4, 2] { { 5, 6,}, { 2, 4 } ,
                                           { 8, 1 }, { 3, 4 } };

            string[,] str = new string[4, 2] { { "one" , "two" },
                                               { "three" , "four" },
                                               { "five" , "six" },
                                               { "seven" , "eight" } };

            int[,,] Arr3D = new int[,,] { { { 1, 2, 3 },
                                            { 4, 5, 6 } },
                                            { { 7, 8, 9 },
                                            { 10, 11, 12 } } };

            int[,,] Arr3Dd = new int[2, 2, 3] { { { 1, 2, 3 },
                                                  { 4, 5, 6 } },
                                                  { { 7, 8, 9 },
                                                  { 10, 11, 12 } } };

            Console.WriteLine("2DArray[0][0] : " + Arr[0, 0]);
            Console.WriteLine("2DArray[0][1] : " + Arr[0, 1]);
            Console.WriteLine("2DArray[1][1] : " + Arr[1, 1]);
            Console.WriteLine("2DArray[2][0] : " + Arr[2, 0]);
            Console.WriteLine();


            Console.WriteLine("2DArray[0][0] (other) : " + Arr_d[0, 0]);
            Console.WriteLine("2DArray[2][0] (other) : " + Arr_d[2, 0]);
            Console.WriteLine("2DArray[3][1] (other) : " + Arr_d[3, 1]);
            Console.WriteLine();

            Console.WriteLine("3DArray[0][0][0] : " + Arr3D[0, 0, 0]);
            Console.WriteLine("3DArray[1][0][2] : " + Arr3D[1, 0, 2]);
            Console.WriteLine();


            Console.WriteLine("3DArray[0][0][0] (other) : " + Arr3Dd[0, 0, 0]);
            Console.WriteLine("3DArray[0][1][0] (other) : " + Arr3Dd[0, 1, 0]);
            Console.WriteLine();

            Console.Write("To String Elements : ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++) 
                {
                    Console.Write(str[i, j]+" ");
                }
            }
        }
    }
}
