using System;

namespace Method
{
    internal class Program
    {
        /*
        static void MyMethod(string fname)
        {
            Console.WriteLine("Welcome "+fname+" !!!");
        }
        static void Main(string[] args)
        {
            MyMethod("Ram");
            MyMethod("Shyam");
            MyMethod("Nayan");
        }
        

        static void MyMethod(string fname, int age)
        {
            Console.WriteLine("Welcome " + fname + ", your age is "+age+" years");
        }
        static void Main(string[] args)
        {
            MyMethod("Ram", 21);
            MyMethod("Shyam", 28);
            MyMethod("Nayan", 30);
        }
        

        static void MyMethod(string fname = "Nayan")
        {
            Console.WriteLine("Welcome " + fname + " !!!");
        }
        static void Main(string[] args)
        {
            MyMethod("Ram");
            MyMethod("Shyam");
            MyMethod();
        }
        

        static int NewMethod(int x)
        {
            return 5 + x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NewMethod(3));
            
        }
        
        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int sumInt = PlusMethodInt(5, 3);
            double sumDouble = PlusMethodDouble(5.5, 3.3);
            Console.WriteLine("Int: "+sumInt);
            Console.WriteLine("Double: "+sumDouble);
        }
        */

        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int sumInt = PlusMethod(5, 3);
            double sumDouble = PlusMethod(5.5, 3.4);
            Console.WriteLine("Int: " + sumInt);
            Console.WriteLine("Double: " + sumDouble);
        }
    }
}
