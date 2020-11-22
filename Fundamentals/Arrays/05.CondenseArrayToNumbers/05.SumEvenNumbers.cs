using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)

        {
            int nums = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .Where(x => x % 2 == 0)
                 .Sum();
            
             Console.WriteLine(nums);
        }
    }
}