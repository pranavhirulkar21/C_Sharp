using System;

namespace PredicateDelegate
{
    internal class Program
    {
        public static bool check(string str)
        {
            if (str.Length < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Predicate<string> val = check;
            Console.WriteLine(val("BridgeLabz"));
            Console.WriteLine(val("Labz"));
        }
    }
}
