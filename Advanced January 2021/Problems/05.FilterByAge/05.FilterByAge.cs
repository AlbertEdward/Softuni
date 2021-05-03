using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Person
    {
        public object Name { get; set; }
        public object Age { get; set; }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ");
                people[i] = new Person();
                people[i].Name = input[0];
                people[i].Age = int.Parse(input[1]);
            }

            string filter = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            
            if (filter == "older")
            {
                for (int j = 0; j < n; j++)
                {
                    

                }

            }

        }
    }
}
