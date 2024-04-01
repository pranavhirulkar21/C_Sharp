using System;

namespace tryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //...Exception =  errors that occurs during execution and disturbs the normal flow of application

            //...try = try some code that is considered "Dangerous"
            //...catch = chatches and handles exceptions when hey occurs
            //...finally = alays execute regardless if exception is caught or not

            int x;
            int y;
            int res;

            try
            {
                Console.Write("Enter number 1 : ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2 : ");
                y = Convert.ToInt32(Console.ReadLine());

                res = x / y;
                Console.WriteLine("Result : " + res);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers please !!!");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You cannot divide by zero !!!");
            } 
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong !!!");
            }
            finally
            {
                Console.WriteLine("All Done !!! \nThanks for visiting !!!");
            }
            Console.ReadKey();
        }
    }
}
