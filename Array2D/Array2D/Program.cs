using System;

namespace Array2D
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2D array
            int[,] array2D = new int[,] 
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine("Value is {0}", array2D[2,0]);

            // 3D array
            int[,,] array3D = new int[,,]
            {
                {
                    {1, 2, 3},
                    {2, 5, 1},
                    {7, 6, 8}
                },

                {
                    {4, 6, 8},
                    {7, 5, 9},
                    {3, 1, 4}
                },

                {
                    {3, 4, 7},
                    {9, 1, 2},
                    {4, 3, 4}
                }
            };

            int dimensions = array3D.Rank;
            Console.WriteLine("Dimensions {0}",dimensions);

            Console.WriteLine("The value is {0}", array3D[0, 2, 1]);
            Console.WriteLine("The value is {0}", array3D[1, 1, 1]);
            Console.WriteLine("The value is {0}", array3D[2, 2, 1]);

            Console.ReadKey();
        }
    }
}
