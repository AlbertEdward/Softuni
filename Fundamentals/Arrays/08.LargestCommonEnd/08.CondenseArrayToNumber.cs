using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            int[] condensed = new int[arr.Length - 1];

            int sum = 0;

            for (int j = 0; j  < condensed.Length - 1; j ++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    condensed[i] = arr[i] + arr[i + 1];
                    sum += condensed[i];
                }
            }
            

            Console.WriteLine(sum);

        }

    }
}