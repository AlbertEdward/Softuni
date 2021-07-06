using System;
namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

        public override double CalculatePerimeter()
        {
            throw new NotImplementedException();
        }

        public override string Draw()
        {
            double rIn = Radius - 0.4;
            double rOut = Radius + 0.4;

            for (double y = 0; y >= -this.Radius; --y)
            {
                for (double x = 0; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }
                }
                Console.WriteLine();
            }
            return "";
        }

    }
}
