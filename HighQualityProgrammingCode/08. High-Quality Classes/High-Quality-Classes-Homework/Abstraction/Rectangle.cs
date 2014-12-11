namespace Abstraction
{
    using System;

    internal class Rectangle : IFigure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        { 
            get 
            {
                return this.width;
            }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be bigger than 0!");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be bigger than 0!");
                }
                this.height = value;
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }
        public double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
