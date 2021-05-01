using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[A-Za-z]+,";
            List<string> input = Console.ReadLine().Split(",").ToList();

            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            while (text != "end of race")
            {
                text = Console.ReadLine();
            }

            Console.WriteLine();

        }
    }
}
