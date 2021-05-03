using System;
using System.Linq;

namespace SumNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        }
    }
}
