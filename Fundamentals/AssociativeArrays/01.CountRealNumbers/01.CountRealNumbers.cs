using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, int> counts = new SortedDictionary<double,int>();

            for (int i = 0; i < nums.Count; i++)
            {
                // ako nqma tozi kluch
                if(!counts.ContainsKey(nums[i])) {
                    // zapazi edinica
                    counts[nums[i]] = 1;
                } else {
                    counts[nums[i]] += 1;
                }
               
            }   

            foreach (KeyValuePair<double, int> kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
