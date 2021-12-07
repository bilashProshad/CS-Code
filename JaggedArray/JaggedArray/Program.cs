using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare jaggedArray
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[2] = new int[] { 2, 3, 5, 1, 6 };

            // alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[]{5,4,3,2,4},
                new int[] { 2, 3, 5, 1, 6 }
            };

            Console.WriteLine(jaggedArray[1][2]);

            for(int i=0; i<jaggedArray2.Length; i++)
            {
                Console.Write("Element {0} : ", i);
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.Write(jaggedArray2[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
