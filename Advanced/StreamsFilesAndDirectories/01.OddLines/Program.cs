using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(Environment.NewLine).Select(int.Parse).Where(x=>x%2=1).List();

            for (int i = 0; i < input.Count; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(input[i]);
                }
            }

        }
    }
}
