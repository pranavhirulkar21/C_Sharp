using System;
using System.Text.RegularExpressions;

namespace Replacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //...1st example
            string badString = "A  String   With   Hell   Lot   of   White   Spaces   ! ! !     ";
            string cleanString = Regex.Replace(badString, "\\s+", " ");
            string cleanedString = Regex.Replace(badString, "\\s+", "-");
            Console.WriteLine($"Cleaned String: {cleanString}");
            Console.WriteLine($"Cleaned String: {cleanedString}");
            Console.WriteLine("\n");


            //...2nd example
            string az = "[a-z]+";
            string str = "Asd2323b0900c1234Def5678Ghi9012Jklm";
            //string str = "Asd23gh23b09gh00c12gh34Def56gh78Ghi90gh12Jklm";
            string[] resultt = Regex.Split(str, az, 
                            RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(500));

            for (int i = 0; i < resultt.Length; i++)
            {
                Console.WriteLine("'{0}'", resultt[i]);
                if(i < resultt.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("\n");


            //...3rd example
            //Regex r = new
        }
    }
}
