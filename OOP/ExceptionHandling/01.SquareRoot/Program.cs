using System;

namespace _01.SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid number");

                a = int.Parse(Console.ReadLine());
                
            }
            finally
            {
                double b = Math.Sqrt(a);
                Console.WriteLine(b);
                Console.WriteLine("Good bye");
            }
        }
    }
}
