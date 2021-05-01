using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _2.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( ?-?2-?) ?([1-9]{3}-?) ?([1-9]{4})";

            var phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, pattern);

            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
