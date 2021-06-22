using System;
namespace _01.Vehicles
{
    public class Car
    {
        public Car(double fuelQuantity, double fuelConsumption, double distance, object liters)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
            this.distance = distance;
            this.liters = liters;
        }

        public double fuelQuantity { get; set; }
        public double fuelConsumption { get; set; }
        public double distance { get; set; }
        public object liters { get; set; }


    }
}
