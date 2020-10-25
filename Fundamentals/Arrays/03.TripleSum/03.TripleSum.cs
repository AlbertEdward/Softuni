using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 0;

            for (int a = 0; a < num.Length - 1; a++)
            {
                for (int b = a + 1; b < num.Length; b++)
                {
                    for (int i = 0; i < num.Length; i++)
                    {
                        if (num[a] + num[b] == num[i])
                        {
                            Console.WriteLine($"{num[a]} + {num[b]} == {num[i]}");

                            counter++;
                        }

                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}