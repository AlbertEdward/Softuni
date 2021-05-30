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
            int beeRow = 0;
            int beeCol = 0;

            for (int row = 0; row < teritory; row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < teritory; col++)
                {
                    beeTeritory[row, col] = input[col].ToString();

                    if (beeTeritory[row, col] == "B")
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }

            int pollinated = 0;

            string commands = Console.ReadLine();

            while (commands != "End")
            {
                beeTeritory[beeRow, beeCol] = ".";

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
                    beeRow++;
                }

                bool isValid = Check(beeCol,beeRow,teritory);

                if (!isValid)
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }

                string checkIndex = beeTeritory[beeRow, beeCol];

                if (checkIndex == "f")
                {
                    pollinated++;
                }
                else if (checkIndex == "O")
                {
                    beeTeritory[beeRow, beeCol] = ".";

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
                        beeRow++;
                    }

                    checkIndex = beeTeritory[beeRow, beeCol];

                    if (checkIndex == "f")
                    {
                        pollinated++;
                    }
                }
                beeTeritory[beeRow, beeCol] = "B";
                commands = Console.ReadLine();

            }

            if (pollinated < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinated} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {pollinated} flowers!");
            }

            int count = 0;

            foreach (var item in beeTeritory)
            {
                Console.Write(item);
                count++;
                if (count >= teritory)
                {
                    Console.WriteLine();
                    count = 0;
                }
            }
        }

        private static bool Check(int beeCol, int beeRow, int teritory)
        {
            return beeCol >= 0 && beeCol < teritory && beeRow >= 0 && beeRow < teritory;
        }
    }
}
