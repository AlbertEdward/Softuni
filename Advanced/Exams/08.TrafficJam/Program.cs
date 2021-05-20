using System;
using System.Linq;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            Queue<string> passedCars = new Queue<string>();

            int count = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    if (passedCars.Count % n == 0)
                    {
                        foreach (var item in passedCars)
                        {
                            Console.WriteLine(item + " passed!");
                            count++;
                        }

                        passedCars.Clear();
                    }
                    else
                    {
                        int c = passedCars.Count - (passedCars.Count / n);

                        for (int i = 0; i < c; i++)
                        {
                            Console.WriteLine(passedCars.Dequeue() + " passed!");
                            count++;

                        }
                    }
                }
                else
                {
                    passedCars.Enqueue(command);
                }

                command = Console.ReadLine();
            }


            Console.WriteLine(count + " cars passed the crossroads.");
        }
    }
}
