using System;

namespace _01.ClassBoxData
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Lenght
        {
            get => this.lenght;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }

                this.lenght = value;
            }
        }

        public double Width
        {
            get => this.width;

            private set
            {
                if (width <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Heigth cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public string Volume()
        {
            double volume = lenght * width * height;
            return $"Volume - {volume:F2}";
        }

        public string SurfaceArea()
        {
            double surfaceArea = 2 * lenght * width + 2 * lenght * height + 2 * width * height;
            return $"Surface Area - {surfaceArea:F2}";
        }

        public string LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * lenght * height + 2 * width * height;

            return $"Lateral Surface Area -  {lateralSurfaceArea:F2}";
        }
    }
}
