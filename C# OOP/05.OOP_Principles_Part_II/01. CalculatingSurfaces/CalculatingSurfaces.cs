using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CalculatingSurfaces
{
    class CalculatingSurfaces
    {
        static void Main(string[] args)
        {
            Circle cirlce = new Circle(4);
            Rectangle rectangle = new Rectangle(4, 5);
            Triangle triangle = new Triangle(3, 5);

            Shape[] shapes = { cirlce, rectangle, triangle };
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
