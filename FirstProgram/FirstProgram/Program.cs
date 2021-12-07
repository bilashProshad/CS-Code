using System;

namespace FirstProgram
{
    class Program
    {
        /// <summary>
        /// Calculate altitude change
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first altitude");
            int firstAltitude = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second altitude");
            int sceondAltitude = int.Parse(Console.ReadLine());

            int altitudeChange = sceondAltitude - firstAltitude;

            Console.WriteLine("Altitude change : " + altitudeChange);
        }
    }
}
