using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Pounds = decimal.Parse(Console.ReadLine());
            decimal dollars = Pounds * 1.31M;
            
            System.Console.WriteLine(Math.Round(dollars,3));



        }
    }
}
