using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextFilter
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] ban = Console.ReadLine().Split(", ");
            string text = Console.Read();

            while (text.Contains(ban[0]) || text.Contains(ban[1]))
            {
                string replacer = "";

                if (text.Contains(ban[0]))
                {
                    for (int i = 0; i < ban[0].Length; i++)
                    {
                        replacer += "*";
                    }
                    text = text.Replace(ban[0], replacer);
                }
                else if (text.Contains(ban[1]))
                {
                    for (int i = 0; i < ban[1].Length; i++)
                    {
                        replacer += "*";
                    }
                    text = text.Replace(ban[1], replacer);
                }
            }

            Console.WriteLine(text);
        }
    }
}
