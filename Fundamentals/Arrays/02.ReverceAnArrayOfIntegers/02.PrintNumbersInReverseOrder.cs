using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nums[i] = num;
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(nums[i] + " ");
            }
           

        }
    }
}