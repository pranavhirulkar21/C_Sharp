
using System;
using System.IO;

namespace ReadAndWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //...Reading nad Writing using StreamReader and StreaWriter
            string data;
            StreamReader reader = null;
            StreamWriter writer = null;
            try
            {
                reader = new StreamReader(@"C:\Users\Pranav Hirulkar\OneDrive\Desktop\C#\FileIO\demo.txt");
                
                data= reader.ReadLine();

                while(data != null)
                {
                    Console.WriteLine(data);
                    data=reader.ReadLine();
                }
                reader.Close();

                writer = new StreamWriter(@"C:\Users\Pranav Hirulkar\OneDrive\Desktop\C#\FileIO\demo.txt");
                writer.WriteLine(@"This is testing of FileI/O.");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                writer.Close();
            }


        }
    }
}
