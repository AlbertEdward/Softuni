using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var reservationNumbers = Console.ReadLine();

            HashSet<string> guests = new HashSet<string>();

            while (reservationNumbers != "PARTY")
            {
                guests.Add(reservationNumbers);
                reservationNumbers = Console.ReadLine();
            }

            reservationNumbers = Console.ReadLine();

            while (reservationNumbers != "END")
            {

                if (guests.Contains(reservationNumbers))
                {
                    guests.Remove(reservationNumbers);
                }

                reservationNumbers = Console.ReadLine();
            }

            Console.WriteLine(guests.Count);

            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
