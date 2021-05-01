using System;

namespace _01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int efficiency = 0;

            for (int i = 0; i < 3; i++)
            {
                int employee = int.Parse(Console.ReadLine());
                efficiency += employee;
            }

            int count = int.Parse(Console.ReadLine());
            int time = 0;

            while (count > 0)
            {
                if (time % 4 != 0 || time == 0)
                {
                    count -= efficiency;
                }
                time++;
            }
            if (time % 4 == 0 && time != 0)
            {
                time++;
            }
            Console.WriteLine($"Time needed: {time}h.");
        }
    }
}
