//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class IsWithinACircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        double radius = 5;
        if ( (x * x) + (y * y) <= (radius * radius) )
        { 
            Console.WriteLine("The point is within the cirlce K(O,5)");
        }
        else
        {
            Console.WriteLine("The point is not within the cirlce K(O,5)");
        }
    }
}

