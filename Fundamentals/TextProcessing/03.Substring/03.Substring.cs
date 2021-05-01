using System;

namespace Substring
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string remove = Console.ReadLine();
            string input = Console.ReadLine();

            while (input.Contains(remove))
            {
                int indexer = input.IndexOf(remove);
                

                input = input.Remove(indexer, remove.Length);
            }

            Console.WriteLine(input);
        }
    }
}
