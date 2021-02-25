using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "swap")
                {
                    int a = array[int.Parse(command[1])];
                    int b = array[int.Parse(command[2])];
                    array[int.Parse(command[1])] = b;
                    array[int.Parse(command[2])] = a;
                }
                else if (command[0] == "multiply")
                {
                    int a = array[int.Parse(command[1])];
                    int b = array[int.Parse(command[2])];
                    array[int.Parse(command[1])] = a * b;
                }
                else if (command[0] == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = array[i] - 1;
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
