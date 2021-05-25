using System;
using System.Linq;

namespace _02._2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = n[0];
            int cols = n[1];

            string[,] matrix = new string[rows, cols];

            int count = 0;

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row,col] == matrix[row,col+1]
                        &&
                        matrix[row+1,col] == matrix[row+1,col+1]
                        &&
                        matrix[row,col] == matrix[row+1,col])
                    {
                        count++;
                    }
                    
                }
            }

            Console.WriteLine(count);
        }
    }
}
