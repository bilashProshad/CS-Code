using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.Length = 5;
            Console.WriteLine(box.Length);
       
            Console.ReadKey();
        }
    }
}
