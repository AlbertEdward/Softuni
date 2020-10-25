using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();

            int j = 0;
            int countBegin = 0;
            int countEnd = 0;
            bool flagBegin = true;
            bool flagEnd = true;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[j] && flagBegin)
                {
                    countBegin++;
                }
                else
                {
                    flagBegin = false;
                }

                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - j] && flagEnd)
                {
                    countEnd++;
                }
                else
                {
                    flagEnd = false;
                }

                j++;

                if (j == arr2.Length)
                {
                    j = 0;
                }
            }

            if (countBegin >= countEnd)
            {
                Console.WriteLine(countBegin);
            }
            else
            {
                Console.WriteLine(countEnd);
            }
        }

    }
}