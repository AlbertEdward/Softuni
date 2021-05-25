using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            int rows = n[0];
            int cols = n[1];

            int[,] matrix = new int[rows, cols];
            int maxSum = int.MinValue;

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int selectedRow = -1;
            int selectedCol = -1;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int currentSum = matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row, col + 2]
                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1]
                        + matrix[row + 1, col + 2]
                        + matrix[row + 2, col]
                        + matrix[row + 2, col + 1]
                        + matrix[row + 2, col + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        selectedCol = col;
                        selectedRow = row;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[selectedRow, selectedCol]} {matrix[selectedRow, selectedCol + 1]} {matrix[selectedRow, selectedCol + 2]}");
            Console.WriteLine($"{matrix[selectedRow+1, selectedCol]} {matrix[selectedRow+1, selectedCol+1]} {matrix[selectedRow+1, selectedCol + 2]}");
            Console.WriteLine($"{matrix[selectedRow+2, selectedCol]} {matrix[selectedRow+2, selectedCol + 1]} {matrix[selectedRow+2, selectedCol + 2]}");
        }
    }
}
