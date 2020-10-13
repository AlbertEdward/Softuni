using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] DaysOfWeek = new string[7] { "Monday","Thuesday","Wednesday","Thursday","Friday","Saturday","Sunday" };

            int num = int.Parse(Console.ReadLine());

            if (!(num > 0 && num < 8))
            {
                Console.WriteLine("Indalid Day!");
                return;
            }

            Console.WriteLine(DaysOfWeek[num-1]);
        }
    }
}
