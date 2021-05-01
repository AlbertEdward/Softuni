using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(x => x * 1.2)
                .ToArray();


            foreach (var price in input)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
