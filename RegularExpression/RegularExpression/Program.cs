using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"there");

            string text = "Hi there, my number is 12314";

            MatchCollection matchCollection = regex.Matches(text);
            Console.WriteLine("{0} hits found", matchCollection.Count);

            foreach (Match match in matchCollection)
            {
                GroupCollection group = match.Groups;
                Console.WriteLine("{0} founds at {1}", group[0].Value, group[0].Index);
            }

            Console.ReadKey();
        }
    }
}

/*
            string pattern = @"there";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12314";

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine("{0} hits found",matchCollection.Count);

            foreach(Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} founds at {1}", group[0].Value, group[0].Index);
            }
*/

