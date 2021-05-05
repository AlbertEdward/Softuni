using System;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine V6 = new Engine(500, 1000);

            Tire[] Pirelli = new Tire[]
            {
                new Tire(2020, 2.0),
                new Tire(2018, 2.5),
                new Tire(2029, 2.2),
                new Tire(2020, 2.3),
            };

            Car CLK = new Car("Mercedes", "W209", 2003, 60, 17, V6, Pirelli);

            Console.WriteLine("HorsePower: " + CLK.Engine.HorsePower);

            foreach (var tire in CLK.Tires)
            {
                Console.WriteLine($"{tire.Year} - {tire.Pressure}");
            }
        }
    }
}
