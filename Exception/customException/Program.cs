using System;

namespace customException
{
    public class CustonEx_age : Exception
    {
        public CustonEx_age(string msg): base(msg) 
        {

        }
    }
    internal class Program
    {
        static int checkAge()
        {
            Console.Write("Enter the age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age < 18)
            {
                throw new Exception("Age should be greater tahn 18 ! ");
            }
            return age;
        }
        static void Main(string[] args)
        {
            try
            {
                int result = checkAge();
                Console.WriteLine("The Age is : "+result);
                Console.ReadLine();
            }
            catch(CustonEx_age e)
            {
                Console.WriteLine(e.Message);

            }

        }
    }
}
