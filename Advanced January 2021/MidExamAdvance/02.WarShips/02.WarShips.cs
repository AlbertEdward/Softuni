using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.WarShips
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n,n];


            string attackInput = Console.ReadLine();
            string[] attack = attackInput.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);


            int FirstPlayerShips = 0;
            int SecondPlayerShips = 0;
            int destroyedShips = 0;

            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                    if (input[col] == "<")
                    {
                        FirstPlayerShips++;
                    }
                    else if (input[col] == ">")
                    {
                        SecondPlayerShips++;
                    }
                }
            }

            for (int i = 0; i < attack.Length; i += 2)
            {
                if (FirstPlayerShips == 0 || SecondPlayerShips == 0)
                {
                    break;
                }

                int row = int.Parse(attack[i]);
                int col = int.Parse(attack[i + 1]);

                bool isNeutral = CheckNegative(col, row, n);
                bool isPositive = CheckPostitive(col, row, n);
                bool isValidSize = CheckValid(col, row, n);
                
                if (isValidSize && matrix[row, col] == "#")
                {
                    if (isNeutral && matrix[row - 1, col] == "<")
                    {
                        destroyedShips++;
                        FirstPlayerShips--;
                        matrix[row - 1, col] = "X";
                    }
                    else if (isNeutral && matrix[row, col - 1] == "<")
                    {
                        destroyedShips++;
                        FirstPlayerShips--;
                        matrix[row, col - 1] = "X";
                    }
                    else if (isPositive && matrix[row + 1, col] == "<")
                    {
                        destroyedShips++;
                        FirstPlayerShips--;
                        matrix[row + 1, col] = "X";
                    }
                    else if (isPositive && matrix[row, col + 1] == "<")
                    {
                        destroyedShips++;
                        FirstPlayerShips--;
                        matrix[row, col + 1] = "X";
                    }
                    else if (isNeutral && matrix[row - 1, col - 1] == "<")
                    {
                        destroyedShips++;
                        FirstPlayerShips--;
                        matrix[row - 1, col - 1] = "X";
                    }
                    else if (isNeutral && isPositive && matrix[row - 1, col + 1] == "<")
                    {
                        destroyedShips++;
                        FirstPlayerShips--;
                        matrix[row - 1, col + 1] = "X";
                    }
                    else if (isNeutral && isPositive && matrix[row + 1, col - 1] == "<")
                    {
                        destroyedShips++;
                        FirstPlayerShips--;
                        matrix[row + 1, col - 1] = "X";
                    }
                    else if (isPositive && matrix[row + 1, col + 1] == "<")
                    {
                        destroyedShips++;
                        FirstPlayerShips--;
                        matrix[row + 1, col + 1] = "X";
                    }

                    if (isNeutral && matrix[row - 1, col] == ">")
                    {
                        destroyedShips++;
                        SecondPlayerShips--;
                        matrix[row - 1, col] = "X";
                    }
                    else if (isNeutral && matrix[row, col - 1] == ">")
                    {
                        destroyedShips++;
                        SecondPlayerShips--;
                        matrix[row, col - 1] = "X";
                    }
                    else if (isPositive && matrix[row + 1, col] == ">")
                    {
                        destroyedShips++;
                        SecondPlayerShips--;
                        matrix[row + 1, col] = "X";
                    }
                    else if (isPositive && matrix[row, col + 1] == ">")
                    {
                        destroyedShips++;
                        SecondPlayerShips--;
                        matrix[row, col + 1] = "X";
                    }
                    else if (isNeutral && matrix[row - 1, col - 1] == ">")
                    {
                        destroyedShips++;
                        SecondPlayerShips--;
                        matrix[row - 1, col - 1] = "X";
                    }
                    else if (isNeutral && isPositive && matrix[row - 1, col + 1] == ">")
                    {
                        destroyedShips++;
                        SecondPlayerShips--;
                        matrix[row - 1, col + 1] = "X";
                    }
                    else if (isNeutral && isPositive && matrix[row + 1, col - 1] == ">")
                    {
                        destroyedShips++;
                        SecondPlayerShips--;
                        matrix[row + 1, col - 1] = "X";
                    }
                    else if (isPositive && matrix[row + 1, col + 1] == ">")
                    {
                        destroyedShips++;
                        SecondPlayerShips--;
                        matrix[row + 1, col + 1] = "X";
                    }
                }
                else if (isValidSize && matrix[row,col] == "<")
                {
                    destroyedShips++;
                    FirstPlayerShips--;
                    matrix[row, col] = "X";
                }
                else if (isValidSize && matrix[row, col] == ">")
                {
                    destroyedShips++;
                    SecondPlayerShips--;
                    matrix[row, col] = "X";
                }
            }

            if (SecondPlayerShips == 0 && FirstPlayerShips != 0)
            {
                Console.WriteLine($"Player One has won the game! {destroyedShips} ships have been sunk in the battle.");
            }
            else if(FirstPlayerShips == 0 && SecondPlayerShips != 0)
            {
                Console.WriteLine($"Player Two has won the game! {destroyedShips} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {FirstPlayerShips} ships left. Player Two has {SecondPlayerShips} ships left.");
            }
        }

        private static bool CheckPostitive(int col, int row, int n)
        {
            return row + 1 <= n && col + 1 <= n;
        }

        private static bool CheckValid(int col, int row, int n)
        {
            return row >= 0 && row <= n && col >= 0 && col <= n;
        }

        public static bool CheckNegative(int col, int row, int n)
        {
            return row - 1 >= 0 && col - 1 >= 0;
                
        }
    }
}
