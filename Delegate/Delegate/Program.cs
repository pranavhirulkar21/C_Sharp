using System;

namespace Delegate
{
    internal class Program
    {
        /*
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);
        public void sum(int a, int b)
        {
            Console.WriteLine("Summation : {0} + {1} = {2}", a, b, a+b);
        }

        public void subt(int a, int b)
        {
            Console.WriteLine("Subtraction : {0} - {1} = {2}", a, b, a - b);
        } 
        static void Main(string[] args)
        {
            Program obj = new Program();

            addnum delObj1 = new addnum(obj.sum);
            subnum delObj2 = new subnum(obj.subt);

            delObj1(100, 40);
            delObj2(100, 40);
        }
        */

        public delegate void rectDelegate(double height, double width);
        public void area(double height, double width)
        {
            Console.WriteLine("Area is : {0}",(height*width));
        }

        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is : {0}", 2*(height + width));
        }

        public static void Main(string[] args)
        {
            Program rect = new Program();

            rectDelegate rectdele = new rectDelegate(rect.area);

            rectdele += rect.perimeter;
            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();

            rectdele.Invoke(16.3, 10.3);

        }
    }
}
