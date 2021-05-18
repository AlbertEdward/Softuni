using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine().Split("").ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                    Console.WriteLine(matrix);





                }
            }
            
        }
    }
}
