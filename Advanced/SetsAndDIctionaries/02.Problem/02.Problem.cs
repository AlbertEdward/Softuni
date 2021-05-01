using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lenghts = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> n = new Stack<int>();
            Stack<int> m = new Stack<int>();
            Stack<int> f = new Stack<int>();

            for (int i = 0; i < lenghts[0]; i++)
            {
                n.Push(int.Parse(Console.ReadLine()));
            }
            for (int j = 0; j < lenghts[1]; j++)
            {
                m.Push(int.Parse(Console.ReadLine()));
            }

      
            for (int x = 0; x < Math.Max(lenghts[0], lenghts[1]); x++)
            {
                int adding = m.Pop();

                if (n.Contains(adding))
                {
                    f.Push(adding);
                }
            }

            
            Stack<int> reversed = new Stack<int>(f); 

            Console.Write(string.Join(" ",reversed));
            
        }
    }
}
