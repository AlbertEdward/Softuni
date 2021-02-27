using System;

namespace _02.Problem
{
    class Program
    {
        /* ha|Do|mm|om|er
         * Move Right 0
         * Move Left 3
         * Check Odd
         * Move Left 2
         * Move Left 10
         * Move Left 0
        */
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|");

            string[] commandsInput = Console.ReadLine().Split();

            string command = commandsInput[0];

            while (command != "Done")
            {
                if (command == "Move")
                {
                    string subCommand = commandsInput[1];
                    int index = int.Parse(commandsInput[2]);
                    if (subCommand == "Right")
                    {
                        int newIndex = index + 1;
                        if (newIndex >= 0 && newIndex < input.Length && (index >= 0 || index < input.Length))
                        {
                            var swap = input[index];
                            input[index] = input[newIndex];
                            input[newIndex] = swap;
                        }

                    }
                    else if (subCommand == "Left")
                    {
                        int newIndex = index - 1;
                        if (newIndex >= 0 && newIndex < input.Length && (index >= 0 || index < input.Length))
                        {
                            var swap = input[index];
                            input[index] = input[newIndex];
                            input[newIndex] = swap;
                        }

                    }
                }
                else if (command == "Check")
                {
                    string subCommand = commandsInput[1];
                    if (subCommand == "Even")
                    {
                        string result = "";
                        for (int i = 0; i < input.Length; i += 2)
                        {
                            result += input[i] + " ";
                        }
                        Console.WriteLine(result.Trim());

                    }
                    else if (subCommand == "Odd")
                    {
                        string result = "";
                        for (int i = 1; i < input.Length; i += 2)
                        {
                            result += input[i] + " ";
                        }
                        Console.WriteLine(result.Trim());
                    }
                }

                commandsInput = Console.ReadLine().Split();
                command = commandsInput[0];

            }

            Console.WriteLine($"You crafted {String.Join("",input)}!");
        }
    }
}
