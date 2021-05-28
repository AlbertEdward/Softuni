using System;
using System.Linq;
using System.Collections.Generic;

namespace Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int teritory = int.Parse(Console.ReadLine());
            string[,] beeTeritory = new string[teritory, teritory];

            for (int row = 0; row < teritory; row++)
            {
                string put = Console.ReadLine()
                    .Split("")
                    .ToString();

                for (int col = 0; col < teritory; col++)
                {
                    beeTeritory[row, col] = ;
                }
            }
            
            int beeRow = 0;
            int beeCol = 0;

            int pollinated = 0;

            for (int i = 0; i < teritory; i++)
            {
                for (int j = 0; j < teritory; j++)
                {
                    if (beeTeritory[i, j] == "B")
                    {
                        beeRow = i;
                        beeCol = j;
                        break;
                    }
                }
            }

            string commands = Console.ReadLine();

            if (commands == "left")
            {
                beeCol--;
            }
            else if (commands == "right")
            {
                beeCol++;
            }
            else if (commands == "up")
            {
                beeRow--;
            }
            else if (commands == "down")
            {
                beeRow--;
            }

            


        }
    }
}
