using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                arr[i] = nums;
            }

            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(arr.Sum());




        }
    }
}
