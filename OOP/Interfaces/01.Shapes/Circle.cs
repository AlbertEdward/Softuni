using System;
namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; set; }

        public void Draw()
        {
            //double rIn = radius - 0.4;
            //double rOut = radius + 0.4;

            //for (double y = radius; y >= -radius; y--)
            //{
            //    for (double x = -radius; x<rOut; x++)
            //    {
            //        double value = x*x+
            //    }
            //}//double rIn = radius - 0.4;
            //double rOut = radius + 0.4;

            //for (double y = radius; y >= -radius; y--)
            //{
            //    for (double x = -radius; x<rOut; x++)
            //    {
            //        double value = x*x+
            //    }
            //}
        }
    }
}
