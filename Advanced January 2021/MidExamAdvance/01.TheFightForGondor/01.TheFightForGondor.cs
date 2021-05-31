using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            List<int> plates = Console.ReadLine()
                .Split(" ", StringSplitOptions
                .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> orcPower = Console.ReadLine()
                    .Split(" ", StringSplitOptions
                    .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .Reverse()
                    .ToList();

            int count = 1;
            int flag = 0;

            while (plates.Count != 0 && orcPower.Count != 0)
            {
                if (count % 3 == 0)
                {
                    plates.Add(int.Parse(Console.ReadLine()));
                    count = 0;
                }


                for (int j = 0; j < Math.Min(plates.Count, orcPower.Count); j++)
                {
                    if (orcPower[j] > plates[j])
                    {
                        orcPower[j] -= plates[j];
                        plates.RemoveAt(j);
                        j--;
                    }
                    else if (orcPower[j] < plates[j])
                    {
                        plates[j] -= orcPower[j];
                        orcPower.RemoveAt(j);
                        j--;
                    }
                    else if (orcPower[j] == plates[j])
                    {
                        orcPower.RemoveAt(j);
                        plates.RemoveAt(j);
                        j--;
                    }
                }

                flag++;

                if (plates.Count == 0)
                {
                    break;
                }
                else if (flag == waves)
                {
                    break;
                }

                int[] input = Console.ReadLine()
                        .Split(" ", StringSplitOptions
                        .RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                count++;
                

                for (int k = input.Length - 1; k >= 0; k--)
                {
                    orcPower.Add(input[k]);
                }
                

            }

            if (plates.Count == 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                if (orcPower.Count > 0)
                {
                    Console.WriteLine("Orcs left: " + string.Join(", ", orcPower));

                }
            }
            else if (plates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");

                if (plates.Count > 0)
                {
                    Console.WriteLine("Plates left: " + string.Join(", ", plates));
                }
            }
        }
    }
}
