using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            List<string> commands = Console.ReadLine()
                .Split()
                .ToList();

            int Cupid = 0;

            while (commands[0] != "Love!")
            {
                if (commands[0] == "Jump")
                {
                    Cupid += int.Parse(commands[1]);
               
                    if (Cupid >= neighborhood.Count)
                    {
                        Cupid = 0;
                    }

                    neighborhood[Cupid] -= 2;

                    if (neighborhood[Cupid] == 0)
                    {
                        Console.WriteLine($"Place {Cupid} has Valentine's day.");
                    }
                    else if (neighborhood[Cupid] < 0)
                    {
                        Console.WriteLine($"Place {Cupid} already had Valentine's day.");
                    }
                }

                commands = Console.ReadLine()
                .Split()
                .ToList();
            }

            Console.WriteLine($"Cupid's last position was {Cupid}.");

            int flag = 0;

            for (int i = 0; i < neighborhood.Count; i++)
            {
                if (neighborhood[i] > 0)
                {
                    flag++;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {flag} places.");
            }
        }
    }
}
