using System;
using System.Text;

namespace _01.Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Gei");
                }

                age = value;           
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Name: {0}, Age {1}", this.name, this.age));

            return sb.ToString();
        }

    }   
}
