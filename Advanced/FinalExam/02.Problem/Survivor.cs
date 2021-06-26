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

            while (commands[0] != "Gong")
            {
                
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);


                if (row > n || row < 0)
                {
                    commands = Console.ReadLine().Split().ToArray();
                    continue;
                }
                else if (jagged[row].Length-1 < col || jagged.Length < 0)
                {
                    commands = Console.ReadLine().Split().ToArray();
                    continue;
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
                        for (int i = 1; i <= 3; i++)
                        {
                            int a = row -i;
                            if (a >= 0)
                            {
                                if (jagged[row - i][col] == "T")
                                {
                                    opponentTokens++;
                                    jagged[row - i][col] = "-";
                                }
                            }

                        }

                    }
                    else if (commands[3] == "down")
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            int a = row + i;
                            if (a <= n)
                            {
                                if (jagged[row + i][col] == "T")
                                {
                                    opponentTokens++;
                                    jagged[row + i][col] = "-";
                                }
                            }

                        }
                    }
                    else if (commands[3] == "left")
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            int a = col - i;
                            if (a >= jagged[row][col].Length)
                            {
                                if (jagged[row][col - i] == "T")
                                {
                                    opponentTokens++;
                                    jagged[row][col - i] = "-";
                                }
                            }

                        }


                    }
                    else if (commands[3] == "right")
                    {
                        for (int i = 1; i <= 3; i++)
                        {
                            int a = col + i;
                            if (a <= jagged[row][col].Length)
                            {
                                if (jagged[row][col + i] == "T")
                                {
                                    opponentTokens++;
                                    jagged[row][col + i] = "-";
                                }
                            }

                        }


                    }

                }
                commands = Console.ReadLine().Split().ToArray();
            }
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Collected tokens: {tokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");
        }
    }
}
