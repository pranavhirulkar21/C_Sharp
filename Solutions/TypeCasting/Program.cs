using System;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //IMPLICIT CASTING

            int n = 10;
            double d = n;

            Console.WriteLine(n);
            Console.WriteLine(d);
            Console.WriteLine();


            //EXPLICIT CASTING

            double dd = 9.87;
            int nn = (int)dd;

            Console.WriteLine(dd);
            Console.WriteLine(nn);
            Console.WriteLine();



            double dou = 123456.789123d;
            float flo = (float)dou;

            Console.WriteLine(dou);
            Console.WriteLine(flo);
        }
    }
}
