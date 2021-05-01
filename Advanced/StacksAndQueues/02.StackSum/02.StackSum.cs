using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .ToLower()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<string> command = Console.ReadLine()
                .Split()
                .ToList();

            Stack<int> sum = new Stack<int>(list);

            int total = 0;
            

            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    sum.Push(int.Parse(command[1]));
                    sum.Push(int.Parse(command[2]));
                }

                if (command[0] == "remove")
                {
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        sum.Pop();
                    }
                }
                command = Console.ReadLine()
                .Split()
                .ToList();
            }

            while (sum.Count > 0)
            {
                total += sum.Pop();
            }

            Console.WriteLine($"Sum: {total}");
        }
    }
}
