using System;

namespace ForEachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];
            name[0] = "John";
            name[1] = "Bilash";
            name[2] = "Joyee";
            name[3] = "Proshad";
            name[4] = "Hira";

            int count = 0;
            foreach(string k in name)
            {
                Console.WriteLine("Name[{0}] = {1}", count, k);
                count++;
            }
            Console.ReadKey();
        }
    }
}
