using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] nameAge = Console.ReadLine().Split(',',' ').ToArray();

                string name = nameAge[0];
                int ages = int.Parse(nameAge[1]);

                dict.Add(name, ages);
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            if (condition == "younger")
            {
                if (format == "name")
                {
                    for (int j = 0; j < age; j++)
                    {
                        if (dict.ContainsValue(age - j))
                        {
                            Console.WriteLine();
                        }
                    }
                }
                
            }
        }
    }
}
