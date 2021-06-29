using System;
namespace _01.Person
{
    public class Child : Person
    {
        private int age;
        public Child(string name, int age)
                : base(name, age)
        {
            Age = age;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Too old for child");
                }
                age = value;
            }
        }

    }
}


