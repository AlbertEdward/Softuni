using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = x => int.Parse(x);

            int[] array = Console.ReadLine().Split(", ").Select(parser).ToArray();

            
            int counter = array.Length;

            Console.WriteLine(counter);
            Console.WriteLine(array.Sum());
        }


    }
}
