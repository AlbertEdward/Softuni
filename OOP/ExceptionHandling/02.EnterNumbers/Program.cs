using System;

namespace _02.EnterNumbers
{
    class Program
    {
      

        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            try
            {
                ReadNumber(start, end);
            }
            catch (Exception ex)
            {

            }
        }

        private static void ReadNumber(int start, int end)
        {
            throw new NotImplementedException();
        }
    }
}
