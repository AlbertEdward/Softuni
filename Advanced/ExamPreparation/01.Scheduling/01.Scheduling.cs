using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    class Scheduling
    {
        static void Main(string[] args)
        {
            List<int> tasks = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .Reverse()
                .ToList();
            List<int> threads = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int needToKill = int.Parse(Console.ReadLine());

            for (int i = 0; i < threads.Count; i++)
            {
                if (tasks[i] == needToKill)
                { 
                    Console.WriteLine($"Thread with value {threads[i]} killed task {needToKill}");
                    break;
                }
                if (threads[i] >= tasks[i])
                {
                    threads.RemoveAt(i);
                    tasks.RemoveAt(i);
                    i--;
                }
                else if (threads[i] < tasks[i])
                {
                    threads.RemoveAt(i);
                    i--;

                }
            }

            Console.WriteLine(string.Join(" ", threads));

        }
    }
}
