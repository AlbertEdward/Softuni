using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            // 0 1 3 3 4
            // 1 2 3 4 5
            List<int> result = new List<int>(numbers.Count/2);

            // 0 -> 2
            // i = 0; numbers.Count - i = 4
            // i = 1; numbers.Count - i = 3
            for (int i = 0; i < result.Count; i++)
            {
                result[i] = numbers[i] + numbers[numbers.Count-i];
            }

            if (numbers.Count % 2 != 0)
            {
                result.Add(numbers[numbers.Count/2]);
            }

            Console.Write(string.Join(" ", result));

        }
    }
}
