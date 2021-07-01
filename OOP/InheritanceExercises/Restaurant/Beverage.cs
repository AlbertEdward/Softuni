using System;
namespace Restaurant
{
    public class Beverage : Product
    {
        public virtual double Mililiters { get; set; }

        public Beverage(string name, decimal price, double mililiters)
            : base(name, price)
        {
            Mililiters = mililiters;
        }

    }
}
