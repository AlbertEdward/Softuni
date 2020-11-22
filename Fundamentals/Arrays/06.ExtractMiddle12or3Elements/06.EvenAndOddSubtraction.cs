using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int totalOdd = 0;
            int totalEven = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    totalEven += nums[i];
                }
                else
                {
                    totalOdd += nums[i];
                }
            }

            Console.WriteLine(totalEven - totalOdd);

        }
    }
}