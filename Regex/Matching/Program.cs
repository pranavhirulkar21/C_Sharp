using System;
using System.Text.RegularExpressions;

namespace Matching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[I]\w+";

            //Regex rg = new Regex(pattern);
            Regex rg = new Regex(pattern, RegexOptions.IgnoreCase); //...does not look for uppercase or lowercase.


            string authors = "Pablo Escobar, indiana Jones, James Bond, Captain Jack Sparrow, Patrick Bateman, The Terminator";

            MatchCollection matchIt = rg.Matches(authors);

            //for(int i = 0; i < matchIt.Count; i++)
            //    Console.WriteLine(matchIt[i].Value);

            
            if(matchIt.Count == 0)
            {
                Console.WriteLine("No Matching Element!!!");
            }
            else
            {
                for(int i = 0; i < matchIt.Count; i++)
                {
                    Console.WriteLine(matchIt[i].Value);
                }
            }


        }
    }
}
