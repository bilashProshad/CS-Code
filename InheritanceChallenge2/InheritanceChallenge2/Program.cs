using System;

namespace InheritanceChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee John = new Employee("Prosad", "Bilash", 40000);

            John.Work();
            John.Pause();

            Boss ChuckNorris = new Boss("Ferrari", "Norris", "Chuck", 9999999);
            ChuckNorris.Lead();

            Trainees michelle = new Trainees(32,8,"Gartner", "Michelle",10000);
            michelle.Learn();
            michelle.Work();

            Console.ReadKey();
        }
    }
}
