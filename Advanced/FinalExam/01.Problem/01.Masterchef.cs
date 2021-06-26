using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ingredient = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> freshness = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();

            int levelFreshness = 0;
            int dippingSauce = 0;
            int greenSalad = 0;
            int chocolateCake = 0;
            int Lobster = 0;

            int max = Math.Min(ingredient.Count, freshness.Count);

            for (int i = 0; i < max; i++)
            {
                levelFreshness = ingredient[i] * freshness[i];

                if (levelFreshness == 0)
                {
                    ingredient.Remove(ingredient[i]);
                    i--;
                    max++;
                    continue;
                }
                else if (levelFreshness == 150)
                {
                    dippingSauce++;
                    ingredient.Remove(ingredient[i]);
                    freshness.Remove(freshness[i]);
                    i--;
                }
                else if (levelFreshness == 250)
                {
                    greenSalad++;
                    ingredient.Remove(ingredient[i]);
                    freshness.Remove(freshness[i]);
                    i--;
                }
                else if (levelFreshness == 300)
                {
                    chocolateCake++;
                    ingredient.Remove(ingredient[i]);
                    freshness.Remove(freshness[i]);
                    i--;
                }
                else if (levelFreshness == 400)
                {
                    Lobster++;
                    ingredient.Remove(ingredient[i]);
                    freshness.Remove(freshness[i]);
                    i--;
                }
                else
                {
                    freshness.Remove(freshness[i]);

                    int saver = ingredient[i] + 5;

                    ingredient.Remove(ingredient[i]);

                    ingredient.Insert(ingredient.Count, saver);

                    i--;
                }

                max = Math.Min(ingredient.Count, freshness.Count);
            }

            if (dippingSauce > 0 &&  greenSalad > 0 && chocolateCake > 0 && Lobster > 0)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                Console.WriteLine($" # Chocolate cake --> {chocolateCake}");
                Console.WriteLine($" # Dipping sauce --> {dippingSauce}");
                Console.WriteLine($" # Green salad --> {greenSalad}");
                Console.WriteLine($" # Lobster --> {Lobster}");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");

                if (ingredient.Sum() > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredient.Sum()}");
                }


                if (chocolateCake > 0)
                {
                    Console.WriteLine($" # Chocolate cake --> {chocolateCake}");
                }
                if (dippingSauce > 0)
                {
                    Console.WriteLine($" # Dipping sauce --> {dippingSauce}");
                }
                if (greenSalad > 0)
                {
                    Console.WriteLine($" # Green salad --> {greenSalad}");
                }
                if (Lobster > 0)
                {
                    Console.WriteLine($" # Lobster --> {Lobster}");
                }
            }

           
        }
    }
}
