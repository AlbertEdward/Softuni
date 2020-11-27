using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .Reverse()
                 .Where(x => x > 0)
                 .ToList();

            if (numbers.Count <= 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
