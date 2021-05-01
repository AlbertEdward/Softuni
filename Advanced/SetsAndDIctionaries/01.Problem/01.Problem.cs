using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Problem
{  
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> data = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string usernames = Console.ReadLine();

                if (!(data.Contains(usernames)))
                {
                    data.Push(usernames);
                }


            }

            Stack<string> revercedData = new Stack<string>(data);

            int count = data.Count;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(revercedData.Pop());
            }




        }
    }
}
