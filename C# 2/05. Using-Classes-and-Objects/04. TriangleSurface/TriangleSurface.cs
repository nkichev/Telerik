//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Enter:\n1: for side and an altitude;\n2: for three sides;\n3: for two sides and an angle between them.");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: SideAndAltitude();
                break;
            case 2: ThreeSides();
                break;
            case 3: TwoSidesAndAngle();
                break;
            default: Console.WriteLine("Wrong input!");
                break;
        }
    }

    private static void SideAndAltitude()
    {
        Console.Write("Enter side: ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("Enter altitude: ");
        double altitude = double.Parse(Console.ReadLine());
        Console.WriteLine("S = {0}", (side * altitude) / 2);
    }

    private static void ThreeSides()
    {
        Console.Write("Enter first side: ");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("Enter second side: ");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("Enter third side: ");
        double thirdSide = double.Parse(Console.ReadLine());

        double p = (firstSide + secondSide + thirdSide) / 2;
        Console.WriteLine("S = {0}", Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide)));
    }

    private static void TwoSidesAndAngle()
    {
        Console.Write("Enter first side: ");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("Enter second side: ");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("Enter angle: ");
        double angle = double.Parse(Console.ReadLine());

        Console.WriteLine("S = {0}", ((firstSide * secondSide * Math.Sin((Math.PI * angle) / 180)) / 2));
    }
}

