using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.FilterByAge
{
    class Person
    {
        public object Name { get; set; }
        public object Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ");
                var name = input[0];
                var age = input[1];

                people[i]  = new Person();
                people[i].Name = name;
                people[i].Age = age;

            }

            string filter = Console.ReadLine();
            int filterAge = int.Parse(Console.ReadLine());

            PrintPeople(people, x = x.Age > filterAge);  
            
        }
        static void PrintPeople(Person[] people, Func<Person, bool> condition)
        {
            
            foreach (var person in people)
            {
                if (condition(person))
                {
                    Console.WriteLine(person);
                }
            }
        }
    }  
}