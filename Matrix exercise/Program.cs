using System;

namespace Array_bi_dimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] xy = Console.ReadLine().Split(' ');
            int N = int.Parse(xy[0]);
            int M = int.Parse(xy[1]);

            int[,] mat = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            } //COLLECTED DATA

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; ++j < M; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < N - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < M - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
