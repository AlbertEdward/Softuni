using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CountCharsInAString
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            StringBuilder sb = new StringBuilder();
            stopwatch.Start();

            for (int i = 0; i < 200000; i++)
            {
                sb.Append(i);
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedMilliseconds);

        }
    }
}
