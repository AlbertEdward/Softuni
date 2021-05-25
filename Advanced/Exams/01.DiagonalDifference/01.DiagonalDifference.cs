using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];

            int primary = 0;
            int secondary = 0;

            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col  < n; col ++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int i = 0; i < n; i++)
            {
                primary += matrix[i, i];
            }

            for (int i = 0; i < n; i++)
            {
                secondary += matrix[i, n-i - 1];
            }

            Console.WriteLine(Math.Abs(primary - secondary));
        }
    }
}
