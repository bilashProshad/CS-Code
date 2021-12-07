using System;
using System.IO;

namespace ReadWriteTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Please enter file name : ");
            string fileName = Console.ReadLine();

            Console.Write("Please enter your text : ");
            string text = Console.ReadLine();

            File.WriteAllText(@"C:\Users\pbila\source\repos\ReadWriteTextFile\ReadWriteTextFile\"+fileName+".txt",text);

            string readText = File.ReadAllText(@"C:\Users\pbila\source\repos\ReadWriteTextFile\ReadWriteTextFile\" + fileName + ".txt");
            Console.WriteLine(readText);
            */

            string[] lines = { "Hello World!", "Bilash Prosad", "Good Morning" };
            File.WriteAllLines(@"C:\Users\pbila\source\repos\ReadWriteTextFile\ReadWriteTextFile\file.txt",lines);

            string[] readLines = File.ReadAllLines(@"C:\Users\pbila\source\repos\ReadWriteTextFile\ReadWriteTextFile\file.txt");
            
            foreach(string line in readLines)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}
