using System;

namespace ProblemSolve
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            while (T>0)
            {
                int N = int.Parse(Console.ReadLine());
                int[] A = new int[N];
                int sum = 0;

                for (int i=0; i<N; i++)
                {
                    A[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < N; i++)
                {
                    sum += A[i];
                }
                Console.WriteLine(sum);
            }
            Console.Read();
        }
    }
}
