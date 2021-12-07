using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
      
class Perimeter
    {

        // declaring enum  
        public enum shapes
        {
            circle,
            square
        }

        public void peri(int val, shapes s1)
        {

            // checking for shape to be circle 
            if (s1 == 0)
            {

                // Output the circumference 
                Console.WriteLine("Circumference of the circle is " +
                                                      2 * 3.14 * val);
            }

            else
            {

                // else output the perimeter of the square 
                Console.WriteLine("Perimeter of the square is " +
                                                         4 * val);
            }
        }
    }

    class Program
    {

        // Main Method 
        static void Main(string[] args)
        {

            Perimeter a1 = new Perimeter();
            a1.peri(3, Perimeter.shapes.circle);
            a1.peri(4, Perimeter.shapes.square);
            

            Console.ReadKey();
        }
    }
} 

