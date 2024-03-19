using System;
using System.Dynamic;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is "+name);
            //Console.WriteLine("Your name is {0}", name);


            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            //int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is: "+age);
            */

            double num = Math.Round(9.45881, 3);
            Console.WriteLine(num);
        }
    }
}
