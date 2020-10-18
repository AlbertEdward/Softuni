using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.SumArray
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int max = Math.Max(arr1.Length, arr2.Length);

           
            int[] sumarr = new int[max];

            for (int i = 0; i < max; i++)
            {
                sumarr[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }

            Console.WriteLine(string.Join(" ", sumarr));
            
         
        }
    }
}
