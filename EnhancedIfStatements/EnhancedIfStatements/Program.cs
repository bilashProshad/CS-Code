using System;

namespace EnhancedIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = -5;
            string stateOfMatter;

            if(temperature < 0)
            {
                stateOfMatter = "Solid";
            }
            else
            {
                stateOfMatter = "Liquid";
            }

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 30;

            stateOfMatter = temperature < 0 ? "Solid" : "Liquid";

            temperature += 100;

            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "Solid" : "Liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);
            Console.Read();
        }
    }
}
