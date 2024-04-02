using System;
using System.IO;
using System.Text;


namespace Operations
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"C:\Users\Pranav Hirulkar\OneDrive\Desktop\C#\FileIO\sample.txt";
            string filePath1 = @"C:\Users\Pranav Hirulkar\OneDrive\Desktop\C#\FileIO\test.txt";
            
            
            //File class methods
            File.Create(filePath);  //...Create a new file
            File.WriteAllText(filePath, "Hello, World");  //...Write text to a file
            string content = File.ReadAllText(filePath);  //...Read all text from the file
            File.Delete(filePath);  //...Delete the file
            

            //FileInfo class methods
            FileInfo fileInfo1 = new FileInfo(filePath1);
            fileInfo1.Create();  //...create a new file
            //fileInfo.AppendText("Appended text");  //...Append text to the file
            long fileSize = fileInfo1.Length;  //...Get the file size
            DateTime creationTime = fileInfo1.CreationTime;  //...Get the file creation

            fileInfo1.Delete();  //...Delete the file
            

            //File class methods
            bool fileExists = File.Exists(filePath);
            Console.WriteLine(fileExists);

            File.Copy(filePath, @"C:\Users\Pranav Hirulkar\OneDrive\Desktop\C#\FileIO\samplesample.txt");
            File.Copy(filePath, @"C:\Users\Pranav Hirulkar\OneDrive\Desktop\C#\FileIO\samplesample.txt");

            File.GetAttributes(filePath);
            string[] fileLines = File.ReadAllLines(filePath);
            File.WriteAllLines(@"C:\Users\Pranav Hirulkar\OneDrive\Desktop\C#\FileIO\samplesample.txt", fileLines);


            // FileInfo class methods
            FileInfo fileInfo11 = new FileInfo(filePath1);
            bool fileExistsInfo = fileInfo1.Exists;
            fileInfo11.CopyTo(@"C:\Users\Pranav Hirulkar\OneDrive\Desktop\C#\copy_info.txt");
            fileInfo11.MoveTo(@"C:\Users\Pranav Hirulkar\OneDrive\Desktop\C#\new_location_info.txt");
            fileInfo11.Open(FileMode.Open);
            FileStream fileStream = fileInfo11.OpenRead();
            Console.WriteLine("File operations completed.");

        }
    }
}
