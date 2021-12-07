using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //   *
            //   **
            //   ***
            //   ****
            //   *****

            /*
            for (int i=1; i<=5; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            */


            //     #
            //    ##
            //   ###
            //  ####
            // #####
            /*for (int i=5; i>=1; i--)
            {
                for(int j=1; j<=5; j++)
                {
                    if (j >= i)
                        Console.Write('#');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }*/

            int n = int.Parse(Console.ReadLine());

            char ch = 'X';

            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=n; j++)
                {
                    Console.Write(ch);

                    if (ch == 'X')
                        ch = 'O';

                    else if (ch == 'O')
                        ch = 'X';
                }
                if (ch == 'X')
                    ch = 'O';

                else if (ch == 'O')
                    ch = 'X';
                Console.WriteLine();
            }


            /*
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=n-i; j++)
                {
                    Console.Write(" ");
                }

                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */

            Console.ReadKey();
        }
    }
}

