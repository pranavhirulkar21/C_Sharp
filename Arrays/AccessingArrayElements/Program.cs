using System;

namespace AccessingArrayElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Arr;
            Arr = new int[5];

            Arr[0] = 20;
            Arr[1] = 30;
            Arr[2] = 10;
            Arr[3] = 50;
            Arr[4] = 40;

            //Accessing elements Using For Loop
            Console.Write("For Loop : ");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i]+ " ");
            }
            Console.WriteLine();


            //Accessing elements Using For-each Loop
            Console.Write("Foreach Loop : ");
            foreach (int i in Arr) 
            { 
                Console.Write(i+" ");
            }
            Console.WriteLine();


            //Accessing elements Using While Loop
            Console.Write("While Loop : ");
            int j = 0;
            while(j < Arr.Length)
            {
                Console.Write(Arr[j]+" ");
                j++;
            }
            Console.WriteLine();


            //Accessing elements Using Do-While Loop
            Console.Write("Do-While Loop : ");
            int k = 0;
            do
            {
                Console.Write(Arr[k]+ " ");
                k++;
            } 
            while(k < Arr.Length);
        }
    }
}
