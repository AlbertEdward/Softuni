using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ \b[A-Z][a-z]+";

            string names = Console.ReadLine();

            MatchCollection machedNames = Regex.Matches(names, pattern);

            foreach (Match name in machedNames)
            {
                Console.Write(name.Value + " ");
            }

        }
    }
}
