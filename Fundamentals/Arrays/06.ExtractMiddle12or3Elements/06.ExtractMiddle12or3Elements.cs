using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ExtractMiddle12or3Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (nums.Length == 1)
            {
                System.Console.WriteLine($"{{ {nums[0]} }}");  
            }
            else if (nums.Length % 2 == 0)
            {
                System.Console.WriteLine($"{{ {nums[(nums.Length/2) -1]}, {nums[(nums.Length/2)]} }}");  
               
            }
            else if (nums.Length % 2 == 1)
            {
                System.Console.WriteLine($"{{ {nums[(nums.Length/2) -1]}, {nums[(nums.Length/2)]}, {nums[((nums.Length/2) + 1)]} }}");  
            }
            
        }
    }
}
