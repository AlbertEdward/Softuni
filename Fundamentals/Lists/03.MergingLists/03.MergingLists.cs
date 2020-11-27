﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> list2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(list1.Count, list2.Count); i++)
            {
                result.Add(list1[i]);
                result.Add(list2[i]);
                
            }

            if (list1.Count > list2.Count)
            {
                for (int i = list2.Count; i < list1.Count ; i++)
                {
                    result.Add(list1[i]);
                }
            }
            else
            {
                for (int i = list1.Count; i < list2.Count; i++)
                {
                    result.Add(list2[i]);
                }
            }
            

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
