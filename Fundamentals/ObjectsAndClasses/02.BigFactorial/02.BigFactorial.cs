using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger x = 1;

            for (int i = 1; i <= n; i++)
            {
                x = i * x;
            }

            Console.WriteLine(x);
        }
    }
}
