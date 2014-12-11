using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalculatingSurfaces
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius 
        {
            get { return this.radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be bigger than zero.");
                }
                else
                {
                    this.radius = value;
                }
            }
        }

        public Circle (double radius) : base(radius, radius)
	    {
            this.Radius = radius;
	    }

        public override double CalculateSurface()
        {
            return Math.PI * (radius * radius);
        }
    }
}
