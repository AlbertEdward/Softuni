using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lilies = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToList();

            List<int> roses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> flowers = new List<int>();

            int wreaths = 0;

            for (int i = 0; i < Math.Min(lilies.Count, roses.Count); i++)
            {
                

                if (roses.Count == 0 && lilies.Count == 0)
                {
                    break;
                }
                else
                {
                    flowers.Add(roses[i] + lilies[i]);
                }

                while (flowers[i] > 15)
                {
                    flowers[i] -= 2;
                }

                if (flowers[i] == 15)
                {
                    flowers.RemoveAt(i);
                    roses.RemoveAt(i);
                    lilies.RemoveAt(i);
                    i--;
                    wreaths++;
                }
            }

            int sum = flowers.Sum();

            if (sum / 15 >= 0)
            {
                wreaths += sum / 15;
            }

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
