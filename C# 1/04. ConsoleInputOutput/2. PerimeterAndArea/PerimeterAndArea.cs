//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class PerimeterAndArea
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double pi = 3.14;
        double perimeter = 2 * pi * r;
        double area = pi * Math.Pow(r, 2);
        Console.WriteLine("The perimeter of the cirlce is {0} and the area is {1}.", perimeter, area);
    }
}

