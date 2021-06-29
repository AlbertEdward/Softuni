using System;
namespace _01.Person
{
    public class Child : Person
    {
        public Child(string name, int age)
         : base(name, age)
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}


