using System;

namespace RepeatStrings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                int lenght = input[i].Length;

                for (int j = 0; j < lenght; j++)
                {
                    Console.Write(input[i]);
                }
                
            }
        }
    }
}
