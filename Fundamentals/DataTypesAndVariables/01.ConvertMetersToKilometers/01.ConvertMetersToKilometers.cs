using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal meters = decimal.Parse(Console.ReadLine());

            decimal kilometers = meters/1000;

            System.Console.WriteLine(Math.Round(kilometers, 2));
        }
    }
}
