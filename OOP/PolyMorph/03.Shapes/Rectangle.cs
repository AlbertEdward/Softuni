using System;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; private set; }
        public double Width { get; private set; }

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
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    sb.Append("*");
                }
                sb.AppendLine();
            }

            return sb.ToString();

        }
    }
}
