using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ceiling: {0}", Math.Ceiling(15.5));
            Console.WriteLine("Floor: {0}", Math.Floor(15.5));

            int num1 = 10;
            int num2 = 9;

            Console.WriteLine("Higher value between {0} & {1} is {2}", num1, num2, Math.Max(10, 9));
            Console.WriteLine("Lower value between {0} & {1} is {2}", num1, num2, Math.Min(10, 9));

            Console.WriteLine("3 to the power 5 is {0}", Math.Pow(3, 5));
            Console.WriteLine("Square root of 25 is {0}", Math.Sqrt(25));

            Console.WriteLine("PI : {0}", Math.PI);
            Console.WriteLine("Abslute of -15 is {0}", Math.Abs(-15));

            Console.WriteLine(Math.E);

            Console.ReadKey();
        }
    }
}
