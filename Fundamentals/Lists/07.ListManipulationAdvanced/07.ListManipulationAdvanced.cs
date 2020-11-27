using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<string> commands = new List<string>();

            bool hasChangedArray = false;

            while (true)
            {
                commands = Console.ReadLine().Split().ToList();

                if (commands[0] == "end")
                {
                    if (hasChangedArray)
                    {
                        Console.WriteLine(String.Join(" ", numbers));
                    }
                    break;
                }
                if (commands[0] == "Add")
                {
                    numbers.Add(int.Parse(commands[1]));
                    hasChangedArray = true;
                }
                else if (commands[0] == "Remove")
                {
                    numbers.Remove(int.Parse(commands[1]));
                    hasChangedArray = true;
                }
                else if (commands[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(commands[1]));
                    hasChangedArray = true;
                }
                else if (commands[0] == "Insert")
                {
                    numbers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                    hasChangedArray = true;
                }
                else if (commands[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(commands[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (commands[0] == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (commands[0] == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 1)));
                }
                else if (commands[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (commands[0] == "Filter")
                {
                    if (commands[1] == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < int.Parse(commands[2]))));
                    }
                    else if (commands[1] == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > int.Parse(commands[2]))));
                    }
                    else if (commands[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= int.Parse(commands[2]))));
                    }
                    else if (commands[1] == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= int.Parse(commands[2]))));
                    }
                }
            }
        }
    }
}
