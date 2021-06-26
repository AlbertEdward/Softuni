using System;
using System.Linq;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[][] jagged = new string[n][];

            for (int row = 0; row < jagged.Length; row++)
            {
                string[] inputNumbers = Console.ReadLine().Split();

                jagged[row] = new string[inputNumbers.Length];

                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = inputNumbers[col];
                }
            }

            string[] commands = Console.ReadLine().Split().ToArray();

            int tokens = 0;
            int opponentTokens = 0;

            while (commands[0] != "Gang")
            {
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);


                if (row > n || row < 0)
                {

                }
                else if (jagged[row].Length < col || jagged.Length < 0)
                {

                }

                if (commands[0] == "Find")
                {

                    if (jagged[row][col] == "T")
                    {
                        tokens++;
                        jagged[row][col] = "-";
                    }

                }
                else if (commands[0] == "Opponent")
                {
                    if (jagged[row][col] == "T")
                    {
                        opponentTokens++;
                        jagged[row][col] = "-";
                    }

                    if (commands[3] == "up")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            int a = row + i;
                            if (a >= 0)
                            {
                                if (jagged[row - i][col] == "T")
                                {
                                    opponentTokens++;
                                    jagged[row][col] = "-";
                                }
                            }

                        }

                    }
                    else if (commands[3] == "down")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            int a = row - i;
                            if (a <= n)
                            {
                                if (jagged[row + i][col] == "T")
                                {
                                    opponentTokens++;
                                    jagged[row][col] = "-";
                                }
                            }

                        }
                    }
                    else if (commands[3] == "left")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            int a = col - i;
                            if (a >= jagged[row].Length)
                            {
                                if (jagged[row][col-i] == "T")
                                {
                                    opponentTokens++;
                                    jagged[row][col] = "-";
                                }
                            }

                        }


                    }
                      else if (commands[3] == "right")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            int a = col + i;
                            if (a <= jagged[row].Length)
                            {
                                if (jagged[row][col+i] == "T")
                                {
                                    opponentTokens++;
                                    jagged[row][col] = "-";
                                }
                            }

                        }


                    }

                }

            }
        }
    }
}
