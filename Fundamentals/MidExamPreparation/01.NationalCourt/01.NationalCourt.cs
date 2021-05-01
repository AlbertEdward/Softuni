using System;

namespace _01.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = 0;
            int efficiency = 0;
            int time = 0;

            for (int i = 0; i < 3; i++)
            {
                int a = int.Parse(Console.ReadLine());

                efficiency += a;
            }

            peopleCount = int.Parse(Console.ReadLine());

            while (peopleCount > 0)
            {
                
                if (time % 4 != 0 || time == 0)
                {
                    
                    peopleCount -= efficiency;
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
