using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] triangle = new int[n][];

            triangle[0][0] = 1;

            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(triangle[i]);
                Console.WriteLine();

            }
        }
    }
}
