using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> arr = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array.Average() < array[i])
                { 
                    arr.Add(array[i]);
                }
            }

            arr = arr.OrderByDescending(x => x).ToList();

            if (arr.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    if (i == 5)
                    {
                        return;
                    }
                    Console.Write(arr[i] + " ");
                }
            }
            

        }

    }
}
