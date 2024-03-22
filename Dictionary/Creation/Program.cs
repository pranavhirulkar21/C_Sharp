using System;
using System.Collections;
using System.Collections.Generic;

namespace Creation
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("1", "Asia");
            dict.Add("2", "NorthAmerica");
            dict.Add("3", "Europe");
            dict.Add("4", "SouthAmerica");
            dict.Add("5", "Africa");
            dict.Add("6", "Australia");
            dict.Add("7", "Antarctica");

            Console.WriteLine("Dictionary Contains : ");
            foreach (KeyValuePair<string, string> kvp in dict)
            {
                Console.WriteLine("Key = {0}, Value = {1}.", kvp.Key, kvp.Value);
            }
            Console.WriteLine();

        }       
    }
}
