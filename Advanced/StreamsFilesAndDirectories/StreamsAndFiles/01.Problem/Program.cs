using System;
using System.IO;
using System.Text;

namespace Problem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            using(StreamReader reader = new StreamReader("../../text.rtf"))
            {
                string currentLine = reader.ReadLine();

                int count = 0;

                while (currentLine != null)
                {
                    if (count % 2 == 1)
                    {
                        Console.WriteLine(currentLine);
                    }
                    currentLine = reader.ReadLine();
                    count++;
                }
            }
        }
    }
}
