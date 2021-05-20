using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int canPass = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            Queue<string> cars = new Queue<string>();

            int passedCars = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < canPass; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCars++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();

            }


            Console.WriteLine(passedCars + " cars passed the crossroads.");
        }
    }
}
