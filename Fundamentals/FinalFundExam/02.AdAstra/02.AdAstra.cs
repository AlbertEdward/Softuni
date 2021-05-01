using System;
using System.Text.RegularExpressions;
using System.Text;

namespace AdAstra
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(\#|\|)(?<item>[A-z]+\s?[A-z]+)\1(?<year>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<callories>[0-9]+)\1";

            Regex regex = new Regex(pattern);
            var match = regex.Match(text);
            int totalCal = 0;

            StringBuilder sb = new StringBuilder();

            while (match.Success)
            {
                totalCal += int.Parse(match.Groups[4].Value);

                sb.AppendLine($"Item: {match.Groups[2].Value}, Best before: {match.Groups[3].Value}, Nutrition: {int.Parse(match.Groups[4].Value)}");

                match = match.NextMatch();
            }

            int days = totalCal / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            Console.WriteLine(sb);
        }
    }
}
