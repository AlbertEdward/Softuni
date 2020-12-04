using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
               .Split("!")
               .ToList();

            List<string> command = Console.ReadLine()
                .Split()
                .ToList();

            while (command[0] != "Go" && command[1] != "Shopping!")
            {
                if (command[0] == "Urgent")
                {
                    if (!(shoppingList.Contains(command[1])))
                    {
                        shoppingList.Insert(0, command[1]);
                    }

                }
                else if (command[0] == "Unnecessary")
                {
                    shoppingList.Remove(command[1]);
                }
                else if (command[0] == "Correct")
                {
                    if (shoppingList.Contains(command[1]))
                    {
                        int index = shoppingList.IndexOf(command[1]);
                        shoppingList.RemoveAt(index);
                        shoppingList.Insert(index, command[2]);
                    }
                }
                else if (command[0] == "Rearrange")
                {
                    string item = command[1];
                    int index = shoppingList.IndexOf(item);
                    
                    if(index >= 0)
                    {
                        shoppingList.RemoveAt(index);
                        shoppingList.Add(item);
                    }
                }

                command = Console.ReadLine()
                .Split()
                .ToList();

            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
