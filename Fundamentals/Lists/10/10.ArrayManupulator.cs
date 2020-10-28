using System;
using System.Linq;
using System.Collections.Generic;

namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> commands = Console.ReadLine().Split().ToList();

            string command = commands[0];

            while (command != "print")
            {
                if (command == "add")
                {
                    int index = int.Parse(commands[1]);
                    int element = int.Parse(commands[2]);

                    nums.Insert(index, element);
                }
                else if (command == "addMany")
                {
                    int index = int.Parse(commands[1]);
                    List<int> rangeToAdd = commands.Skip(2).Select(int.Parse).ToList();
                    nums.InsertRange(index, rangeToAdd);
                }
                else if (command == "contains")
                {
                    int ElToBeFound = int.Parse(commands[1]);

                    Console.WriteLine(nums.IndexOf(ElToBeFound));
                }
                else if (command == "remove")
                {
                    int index = int.Parse(commands[1]);
                    nums.RemoveAt(index);
                    
                }
                else if (command == "shift")
                {
                    int timesToBeShift = int.Parse(commands[1]);

                    for (int i = 1; i <= timesToBeShift; i++)

                    {
                        int firstEl = nums[0];
                        nums.RemoveAt(0);
                        nums.Add(firstEl);
                    }

                }
                else if (command == "sumPairs")
                {

                    List<int> summed = new List<int>();

                    // 0 1 2 3 4 5 6
                    // 1   5   9   6
                    for (int i = 0; i < nums.Count-1; i+=2)
                    {
                        summed.Add(nums[i] + nums[i + 1]);

                    }
                    if (nums.Count % 2 != 0)
                    {
                        summed.Add(nums[nums.Count - 1]);
                    }
                    nums = summed;
                }

                commands = Console.ReadLine().Split().ToList();
                command = commands[0];

            }

            Console.WriteLine("[" + string.Join(", ", nums) + "]");
             
        }
    }
}
