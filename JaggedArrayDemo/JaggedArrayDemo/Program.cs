using System;


namespace JaggedArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray1 = new int[3][];

            jaggedArray1[0] = new int[3];

            jaggedArray1[0][0] = 2;
            jaggedArray1[0][1] = 4;
            jaggedArray1[0][2] = 3;

            jaggedArray1[1] = new int[] {1, 4, 5, 3, 8};
            jaggedArray1[2] = new int[4] {5, 1, 4 ,7};

            Console.WriteLine(jaggedArray1[1][2]);


            int[][] jaggedArray2 = new int[][]
            {
                new int[] {1, 2, 3, 4, 5},
                new int[] {2, 1, 9, 0, 1},
                new int[] {4, 2, 5, 1, 2}
            };

            Console.WriteLine(jaggedArray2[2][3]);

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Element in position {0} : ",i);
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
