using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> words = Console.ReadLine().Split().ToList();

            Random rnd = new Random();
            int wordsCount = words.Count;

            for (int i = 0; i < wordsCount; i++)
            {

                int index = rnd.Next(0, words.Count);

                System.Console.WriteLine(words[index]);
                words.RemoveAt(index);
            }
        }
    }
}
