using System;
using System.Text;

namespace FINALEXAM
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Sign up")
            {
                string[] splitted = command.Split();

                if (splitted[0] == "Case")
                {
                    if (splitted[1] == "lower")
                    {
                        input = input.ToLower();
                    }
                    else if (splitted[1] == "upper")
                    {
                        input = input.ToUpper();
                    }

                    Console.WriteLine(input);
                }
                else if (splitted[0] == "Reverse")
                {
                    var startIndex = int.Parse(splitted[1]);
                    var endIndex = int.Parse(splitted[2]);

                    if (startIndex <= endIndex)
                    {
                        if (startIndex >= 0 && endIndex <= input.Length)
                        {
                            string str = input.Substring(startIndex, endIndex);

                            char[] charArray = str.ToCharArray();
                            Array.Reverse(charArray);

                            Console.WriteLine(charArray);
                        }
                    }
                    
                }
                else if (splitted[0] == "Cut")
                {
                    int index = input.IndexOf(splitted[1]);

                    if (index >= 0)
                    {
                        input = input.Remove(index, splitted[1].Length);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine($"The word {input} doesn't contain {splitted[1]}.");
                    }
                }
                else if (splitted[0] == "Replace")
                {
                    input = input.Replace(splitted[1], "*");
                    Console.WriteLine(input);
                }
                else if (splitted[0] == "Check")
                {
                    if (input.Contains(splitted[1]))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {splitted[1]}.");
                    }
                }

                command = Console.ReadLine();

                bool isbool = true;
                int value = int.Parse(isbool);


            }
        }
    }
}
