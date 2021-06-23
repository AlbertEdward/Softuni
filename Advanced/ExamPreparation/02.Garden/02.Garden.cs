using System;
using System.Linq;

namespace _02.Garden
{
    class Garden
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int l = 0; l < dimensions[1]; l++)
                {
                    matrix[i, l] = 0;
                }
            }

            string commands = Console.ReadLine();

            while (commands != "Bloom Bloom Plow")
            {
                string[] task = commands.Split().ToArray();

                int row = int.Parse(task[0]);
                int col = int.Parse(task[1]);

                if (row > dimensions[0] || col > dimensions[1] || row < 0 || col < 0)
                {
                    Console.WriteLine("Invalid coordinates.");
                    commands = Console.ReadLine();
                    continue;
                }

                for (int i = 0; i < dimensions[0]; i++)
                {
                    if (matrix[row,i] == 0)
                    {
                        matrix[row, i] = 1;
                    }
                    else
                    {
                        matrix[row, i] += 1;
                    }
                }
                for(int j = 0; j < dimensions[1]; j++)
                {
                    if (matrix[j,col] == 0)
                    {
                        matrix[j, col] = 1;
                    }
                    else
                    {
                        matrix[j, col] += 1;
                    }
                }

                matrix[row, col] = 1;

                commands = Console.ReadLine();
            }

            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int k = 0; k < dimensions[1]; k++)
                {
                    Console.Write(matrix[i,k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
