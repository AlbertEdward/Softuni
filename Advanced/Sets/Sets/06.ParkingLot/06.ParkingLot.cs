using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var carNumbers = Console.ReadLine().Split(", ");
            HashSet<string> parking = new HashSet<string>();

            while (carNumbers[0] != "END")
            {
                if (carNumbers[0] == "IN")
                {
                    parking.Add(carNumbers[1]);
                }
                if (carNumbers[0] == "OUT")
                {
                    parking.Remove(carNumbers[1]);
                }

                carNumbers = Console.ReadLine().Split(", ");
            }

            if (parking.Count != 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
