using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> filter = input => char.IsUpper(input[0]);

            string input = Console.ReadLine();
            string[] text = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            text = text.Where(filter).ToArray();

            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
