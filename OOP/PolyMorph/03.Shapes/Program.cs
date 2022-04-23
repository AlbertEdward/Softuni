using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var star = '*';
            var newLine = '\n';

            for (int col = 0; col < n; col++)
            {

                for (int row = 0; row < n; row++)
                {
                    Console.Write(star);
                }
                Console.WriteLine(newLine);
            }
        }
    }
}
