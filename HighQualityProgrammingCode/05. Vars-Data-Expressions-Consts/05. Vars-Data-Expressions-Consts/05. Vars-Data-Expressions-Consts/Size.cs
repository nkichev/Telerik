namespace _05.Vars_Data_Expressions_Consts
{
    using System;
    using System.Linq;

    internal class Size 
    {
        private double width;
        private double height;

        public Size(double width, double height)
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
                this.height = value;
            } 
        }

        public static Size Rotate(Size target, double angle)
        {
            double angleCos = Math.Abs(Math.Cos(angle));
            double angelSin = Math.Abs(Math.Sin(angle));

            target.Width = (angleCos * target.Width) + (angelSin * target.Height);
            target.Height = (angelSin * target.Width) + (angleCos * target.Height);

            return target;
        }
    }
}
