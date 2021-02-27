using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allCards = Console.ReadLine().Split(":").ToList();

            List<string> newDeck = new List<string>();

            string[] commands = Console.ReadLine().Split();
            string command = commands[0];

            while (command != "Ready")
            {
                if (command == "Add")
                {
                    if (allCards.Contains(commands[1]))
                    {
                        newDeck.Add(commands[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                    
                }
                else if (command == "Insert")
                {
                    int hui = int.Parse(commands[2]);

                    if (allCards.Contains(commands[1]) && hui >= 0 && hui < newDeck.Count)
                    {
                        newDeck.Insert(int.Parse(commands[2]), commands[1]);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    
                }
                else if (command == "Remove")
                {
                    if (newDeck.Contains(commands[1]))
                    {
                        newDeck.Remove(commands[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (command == "Swap")
                {
                    var firstIndex = newDeck.IndexOf(commands[1]);
                    var secondIndex = newDeck.IndexOf(commands[2]);

                    if(firstIndex<0 || secondIndex<0) {continue;}


                    var swap = newDeck[firstIndex];
                    newDeck[firstIndex] = newDeck[secondIndex];
                    newDeck[secondIndex] = swap;
                }
                else if (command == "Shuffle")
                {
                    newDeck.Reverse();
                }

                commands = Console.ReadLine().Split();
                command = commands[0];
            }

            Console.WriteLine(string.Join(" ", newDeck));
        }
    }
}
