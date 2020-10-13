using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) != Math.Truncate(Math.Sqrt(numbers[i])))
                {
                    numbers.RemoveAt(i);
                    i--;
                }
                
            }
            Console.WriteLine(string.Join(" ", numbers));
            
        }
    }
}
