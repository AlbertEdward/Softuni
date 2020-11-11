using System;
using System.Linq;
using System.Collections.Generic;

namespace _09.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> commands = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bomb = commands[0];
            int power = commands[1];
            

            while (numbers.Contains(bomb))
            {
                int bombIndex = numbers.IndexOf(bomb);

                int leftIndex = bombIndex - power;
                int rightIndex = bombIndex + power;


                if (leftIndex >= 0 && rightIndex < numbers.Count)
                {
                    numbers.RemoveRange(leftIndex, rightIndex - leftIndex + 1);
                }
                else if (leftIndex < 0 && rightIndex >= numbers.Count)
                {
                    Console.WriteLine(0);
                    return;
                }
                else if (leftIndex < 0)
                {
                    numbers.RemoveRange(0, rightIndex + 1);
                }
                else if (rightIndex >= numbers.Count)
                {
                    numbers.RemoveRange(leftIndex, (numbers.Count - leftIndex));
                }
            }

            Console.WriteLine(numbers.Sum());

        }
    }
}
