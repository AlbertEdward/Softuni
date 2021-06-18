using System;

namespace Shapes
{
    public abstract class Shape
    {
        private double height;
        private double width;

        public Shape(double height, double widht)
        {
            Height = height;
            Widht = widht;
        }

        public double Height { get; set; }
        public double Widht { get; set; }

        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return null;
        }
    }
}
