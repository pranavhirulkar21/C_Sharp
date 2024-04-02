using System;

namespace FuncDelegate
{
    internal class Program
    {
        private static int multiply(int x, int y, int z, int w)
        {
            return x * y * z * 5;
        }

        public static int add(int num)
        {
            return num + num;
        }
        public static void Main()
        {
            Func<int, int, int, int, int> val = multiply;
            Console.WriteLine(val(2, 3, 4, 5));

            Console.WriteLine();

            Func<int, int> value = add;
            Console.WriteLine((value(10)));
        }


        
        

    }
}
