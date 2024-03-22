using System;
using System.Collections;
using System.Collections.Generic;

namespace Opeartions
{
    internal class Program
    {
        public static void display(Dictionary<string, string> dictionary)
        {
            Console.WriteLine("Dictionay Contains : ");
            foreach (KeyValuePair<string, string> kvp in dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}.", kvp.Key, kvp.Value);
            }
            Console.WriteLine();
        }

        public static void displayOnlyKeys(Dictionary<string, string> dictionary)
        {
            Dictionary<string, string>.KeyCollection keys = dictionary.Keys;
            Console.WriteLine("Keys in the Dictionary : ");
            foreach (string key in keys)
            {
                Console.WriteLine("key = {0}", key);
            }
            Console.WriteLine();
        }

        public static void displayOnlyValues(Dictionary<string, string> dictionary)
        {
            Dictionary<string, string>.ValueCollection values = dictionary.Values;
            Console.WriteLine("Values in the Dictionary : ");
            foreach (string value in values)
            {
                Console.WriteLine("Value = {0}", value);
            }
            Console.WriteLine();
        }

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

            display(dict);

            Console.WriteLine("Total key/value pairs in Dictionary : " + dict.Count);
            Console.WriteLine();

            displayOnlyKeys(dict);

            displayOnlyValues(dict);

            //TO REMOVE ALL THE KEY/VALUE PAIRS IN DICTIONARY
            //dict.Clear();

            //TO REMOVE THE VALUE FROM SPECIFIC KEY IN DICTIOANRY
            //dict.Remove("3");

            //TO CHANGE VALUE OF A SPECIFIC KEY IN DICTIONARY
            //dict[key] = newvalue;

            Console.WriteLine("Before change : ");
            display(dict);

            Console.WriteLine("After change : ");
            dict["7"] = "TEST";
            display(dict);

            // TO CHECK IF TWO DICTIONARIES ARE EQUAL OR NOT
            Console.WriteLine(dict.Equals(dict));

            //TO CHECK WHETHER A SPECIFIC KEY AND VALUE PRESENT IN DICTIOANRY OR NOT
            Console.WriteLine(dict.ContainsKey("3"));
            Console.WriteLine(dict.ContainsValue("Asia"));
            Console.WriteLine();

            //ENUMERATOR
            IDictionaryEnumerator enumerator = dict.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Key + " --> " + enumerator.Value);
            }

        }
    }
}
