using System;
namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public double Caffeine { get; set; }
        public const double DefaulCaffeeMililiters = 50;
        public const decimal DefaultCaffeePrice = 3.50m;
        
        public Coffee(string name, double caffeine)
            : base(name, DefaultCaffeePrice, DefaulCaffeeMililiters)
        {
            Caffeine = caffeine;
        }

    }
}
