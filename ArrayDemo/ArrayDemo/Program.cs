using System;


namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array3D = new int[,,] 
            {
                {
                    {1, 2, 3},
                    {2, 5, 6}
                },
                {
                    {7, 5, 6},
                    {0, 7, 5}
                }
            };

            Console.WriteLine(array3D[1,1,1]);

            Console.ReadKey();
        }
    }
}
