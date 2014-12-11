using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalculatingSurfaces
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be bigger than zero.");
                }
                else
                {
                    this.width = value;
                }
            }
        }
        public double Height 
        {
            get { return this.height; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be bigger than zero.");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateSurface();
    }
}
