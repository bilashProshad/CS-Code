using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Human john = new Human();
            john.firstName = "Bilash";
            john.lastName = "Proshad";
            john.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
