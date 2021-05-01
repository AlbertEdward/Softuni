using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseStrings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] c = input.ToCharArray();
            Stack<char> stack = new Stack<char>();

            foreach (var item in c)
            {
                stack.Push(item);
            }

            foreach (var i in c)
            {
                Console.Write(stack.Pop()); 
            }
        }
    }
}
