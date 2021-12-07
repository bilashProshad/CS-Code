using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListVsList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 99, 96, 87, 76 };

            List<int> list = new List<int> { 1, 2, 3, 4 };
            list.Add(0);
            list.Add(32);
            list.Sort();
            list.RemoveRange(2, 2);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(list.Contains(4));

            // find index of 4 using delegate
            //int index = list.FindIndex(delegate(int i) { return i == 4; } );

            // find index of 4 using lambda expression
            int index = list.FindIndex(x => x == 4);
            Console.WriteLine(list[index]);

            list.RemoveAt(index);

            //Console.WriteLine(list.IndexOf(4));

            list.ForEach(i => Console.WriteLine(i)); 

            Console.ReadKey();
        }
    }
}




