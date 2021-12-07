using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    class Human
    {
        public string firstName;
        public string lastName;

        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }
    }
}
