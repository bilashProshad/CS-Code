using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = {"first 250", "second 242", "third 240"};
            /*
            File.WriteAllLines(@"C:\Users\pbila\source\repos\FileIO\highscores.txt", lines);

            Console.Write("Please enter file name : ");
            string fileName = Console.ReadLine();

            Console.Write("Please enter your text : ");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\pbila\source\repos\FileIO\"+ fileName +".txt", input);

            string text = File.ReadAllText(@"C:\Users\pbila\source\repos\FileIO\" + fileName + ".txt");
            Console.WriteLine(text);
            */
            /*
            // Example-1: Reading text
            string text = System.IO.File.ReadAllText(@"C:\Users\pbila\source\repos\FileIO\textFile.txt");
            Console.WriteLine("Text file contains the following text: ");
            Console.WriteLine(text);

            
            // Example-2: Reading text
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\pbila\source\repos\FileIO\textFile.txt");

            /*
            for(int i=0; i<lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
            */

            /*
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            */

            /*
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
            */

            using (StreamWriter file = new StreamWriter(@"C:\Users\pbila\source\repos\FileIO\myText2.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("2"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\Users\pbila\source\repos\FileIO\myText2.txt",true))
            {
                file.WriteLine("Additional line");
            }

            Console.ReadKey();
        }
    }
}



