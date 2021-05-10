using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreath
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lilies = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToList();
            List<int> roses = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> stored = new List<int>();

            int wreath = 0;

           for (int i = 0; i < lilies.Count; i++)
            {
                while (lilies[i] + roses[i] > 15)
                {
                    lilies[i] -= 2;
                }

                if (lilies[i] + roses[i] < 15)
                {
                    stored.Add(roses[i]+lilies[i]);
                }

                if (lilies[i] + roses[i] == 15)
                {
                    wreath++;
                    lilies.RemoveAt(i);
                    roses.RemoveAt(i);
                    i--;
                }
            }

            if (stored.Sum() % 15 > 0)
            {
                wreath += stored.Sum() / 15;
            }

            if (wreath >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreath} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreath} wreaths more!");
            }
        }
    }
}
