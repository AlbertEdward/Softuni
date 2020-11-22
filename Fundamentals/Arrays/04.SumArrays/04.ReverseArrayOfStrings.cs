using System;
using System.Collections.Generic;
using System.Linq;


namespace ReverseArrayOfStrings
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine().Split().ToArray();

            Console.Write(string.Join(" ", letters.Reverse()));
        }
    }
}