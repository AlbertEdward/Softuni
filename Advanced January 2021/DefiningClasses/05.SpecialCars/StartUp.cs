using System;
using System.Linq;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "No more tires")
            {
                string[] tireInfo = Console.ReadLine().Split();

                new Tire(int.Parse(tireInfo[0]), double.Parse(tireInfo[1]));

                command = Console.ReadLine();
            }

            while (command != "Engines done")
            {
                string[] engineInfo = Console.ReadLine().Split();

                new Engine(int.Parse(engineInfo[0]), double.Parse(engineInfo[1]));

                command = Console.ReadLine();
            }
            
            while (command != "Show special")
            {
                string[] carsInfo = Console.ReadLine().Split();



                command = Console.ReadLine();
            }
        }
    }
}
