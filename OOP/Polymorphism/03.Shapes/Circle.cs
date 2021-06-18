using System;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(double height, double widht) : base(height, widht)
        {
        }

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
            return base.Draw();
        }
    }
}
