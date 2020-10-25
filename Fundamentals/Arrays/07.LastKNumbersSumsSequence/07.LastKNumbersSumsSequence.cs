using System;

namespace _07.LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] seq = new int[n];

            seq[0] = 1;

            for (int i = 1; i < n; i++)
            {
                int result = 0;

                for (int j = i - 1; j >= 0 && j >= i - k; j--)

                {
                    result += seq[j];
                }

                seq[i] = result;
            }

            Console.WriteLine(string.Join(" ", seq));

        }
    }
}