using System;

namespace _01.IvansBABY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is my baby sex:  ");
            string babyType = Console.ReadLine();
            int girls = 0;
            int gender = 0;
            while (babyType != "boy" || babyType != "boy")
            {
                if (babyType == "girl" || babyType == "Girl")
                {
                    Console.WriteLine("Try again!");
                    girls++;
                }
                else if (babyType == "gender" || babyType == "Gender")
                {
                    Console.WriteLine("Мамата си е ебало");
                    gender++; 
                }
                
                Console.Write("Enter baby sex: ");
                babyType = Console.ReadLine();
            }
            Console.WriteLine();

            Console.WriteLine("Mission Complete!");
            Console.WriteLine($"You have total {girls + 1 + gender} kids.");
            Console.WriteLine($"Girls -> {girls}");
            Console.WriteLine($"Genders -> {gender}");
            Console.WriteLine("Boys -> 1");
            
        }
    }
}
