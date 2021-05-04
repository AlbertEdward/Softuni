using System;
using System.Linq;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split().ToList();

            List<string> newNames = names.Select(name => $"Sir {name}").ToList();
        }
    }
}
