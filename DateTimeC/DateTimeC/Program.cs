using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeC
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(1998, 4, 19);

            Console.WriteLine("My birthday is {0}", dateTime);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be the {0}",tomorrow);

            Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);
            Console.WriteLine("Today is {0} day of the year", DateTime.Today.DayOfYear);
            Console.WriteLine("Month is {0}", DateTime.Today.Month);
            Console.WriteLine(GetFirstDayOfYear(1998));

            int days = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Days in Feb 2000 : {0}", days);

            DateTime now = DateTime.Now;
            Console.WriteLine("Minute : {0}", now.Minute);

            Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

            /*
            Console.WriteLine("Write a date in this format : yyyy-mm-dd");
            string input = Console.ReadLine();

            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Days passed since: {0}", daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
            */

            Console.WriteLine("Write your birthday date in this format : yyyy-mm-dd");
            string input = Console.ReadLine();

            if(DateTime.TryParse(input, out dateTime))
            {
                TimeSpan age = now.Subtract(dateTime);
                Console.WriteLine("You are {0} days old", age.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            Console.ReadKey();
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}

