using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CondenseArrayToNumbers
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = nums.Length - 2; j >= 0; j--)
            {
                for (int i = 0; i <= j; i++)
                {
                    nums[i] = nums[i] + nums[i + 1];
                }
            }

            Console.WriteLine(nums[0]);
        }
    }
}