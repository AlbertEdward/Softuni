using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.FilterByAge
{
    class Person
    {

        private int _age;
        public Person(string name, int age, string egn) {
            this.Name = name;
            this.Age = age;
            this.EGN = egn;
        }
        private string EGN;
        public string Name { get; set; }
        public int Age { 
            get { return this._age; }
            set { this._age = value;}
        }        
        public string GetFirstDigitsOfEGN(int numberOfDigits)
        {
            return this.EGN.Substring(numberOfDigits);
        }
    }










    class Person2 {
        private int _age;

        public int GetAge()
        {
            return this._age;
        }

        public void SetAge(int age)
        {
            this._age = age;
        }
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
                var age = int.Parse(input[1]);
                people[i] = new Person();
                people[i].Name = name;
                people[i].Age = age;
            }

            // rajda se 
            Person chovek = new Person("gosho", 0, "2102101234");

            Person2 chovek2 = new Person2();
            
            chovek.Age = 0;
            chovek2.SetAge(10);


            int t = chovek.Age;
            int t2 = chovek2.GetAge();


            chovek.GetFirstDigitsOfEGN(6);


            string filter = Console.ReadLine();
            int filterAge = int.Parse(Console.ReadLine());
            string filterNameAge = Console.ReadLine();



        }
    }
}
