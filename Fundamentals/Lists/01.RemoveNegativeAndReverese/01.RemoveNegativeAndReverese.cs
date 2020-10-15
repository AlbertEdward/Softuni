using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.RemoveNegativeAndReverese
{
    class Program
    {
        static void Main(string[] args)
        {
             
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> num = new List<int>();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] > 0)
                {
                    num.Add(numbers[i]);
                }
            }

            if (num.Count == 0)
            {
                Console.WriteLine("Empty");
                return;
            }

            Console.WriteLine(string.Join(" ",num));
            
        }
    }
}
