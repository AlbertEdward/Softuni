using System;
using System.Text.RegularExpressions;

namespace Problem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string pattern = @"!([A-Z][a-z]{2,})!:\[([A-Za-z]{8,})\]";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex r = new Regex(pattern);
                Match m = r.Match(input);

                if (!m.Success)
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }

                string command = m.Groups[1].Value;
                string message = m.Groups[2].Value;
               
                int[] marks = new int[message.Length];

                for (int j = 0; j < message.Length; j++)
                {
                    marks[j] = Convert.ToInt32(message[j]);
                }
                Console.WriteLine($"{command}: {string.Join(" ", marks)}");
            }

        }
    }
}
