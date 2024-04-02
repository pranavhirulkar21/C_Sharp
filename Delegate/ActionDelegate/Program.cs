using System;

namespace ActionDelegate
{
    internal class Program
    {
        public static void add(int a, int b)
        {
            Console.WriteLine("Add : {0}",a+b);
        }
        static void Main(string[] args)
        {
            Action<int, int> val = add;
            val(10, 8);
        }
    }
}
