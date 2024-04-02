using System;
using System.IO;

namespace ReadAndWriteUsingFileClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists(@"C:\Users\Pranav Hirulkar\OneDrive\Desktop\C#\FileIO\demo.txt"))
            {
                string txtFile = File.ReadAllText(@"C:\Users\Pranav Hirulkar\OneDrive\Desktop\C#\FileIO\demo.txt");
                Console.WriteLine(txtFile);
            }

            if (File.Exists(@"C:\Users\Pranav Hirulkar\OneDrive\Desktop\C#\FileIO\demo.txt"))
            {
                string newtxt = @"Testing is still happening here!!!";

                File.WriteAllText(@"C:\Users\Pranav Hirulkar\OneDrive\Desktop\C#\FileIO\demo.txt", newtxt);
            }

        }
    }
}
