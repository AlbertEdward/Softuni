using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var continents = input[0];
                var countries = input[1];
                var cities = input[2];

                if (!dict.Keys.Contains(continents))
                {
                    dict.Add(continents, new Dictionary<string, List<string>>());
                }

                if (!dict[continents].Keys.Contains(countries))
                {
                    dict[continents].Add(countries, new List<string>());
                }

                dict[continents][countries].Add(cities);
                

            }

            foreach (var continents in dict)
            {
                Console.WriteLine($"{continents.Key}:");

                foreach (var countries in continents.Value)
                {
                    Console.Write($"    {countries.Key} -> ");
                    Console.WriteLine(string.Join(", ", countries.Value));
                }
            } 
        }
    }
}
