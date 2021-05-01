using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            Stack<string> calc = new Stack<string>(input);



        }
    }
}
