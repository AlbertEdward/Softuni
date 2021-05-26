using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string invitedGuest = Console.ReadLine();
            List<string> regular = new List<string>();
            List<string> vip = new List<string>();

            while (invitedGuest != "PARTY" && invitedGuest != "END")
            {
                bool isDigit = char.IsDigit(invitedGuest[0]);

                if (isDigit)
                {
                    vip.Add(invitedGuest);
                }
                else
                {
                    regular.Add(invitedGuest);
                }

                invitedGuest = Console.ReadLine();
            }
            string attended = invitedGuest;

            if (attended == "PARTY")
            {
                while (attended != "END")
                {
                    if (vip.Contains(attended))
                    {
                        vip.Remove(attended);
                    }
                    else if (regular.Contains(attended))
                    {
                        regular.Remove(attended);
                    }

                    attended = Console.ReadLine();
                }
            }

            int count = vip.Count() + regular.Count();

            Console.WriteLine(count);
            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regular)
            {
                Console.WriteLine(item);
            }

        }
    }
}
