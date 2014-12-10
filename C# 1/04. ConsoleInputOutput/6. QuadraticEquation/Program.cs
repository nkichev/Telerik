    //Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 
//and solves it (prints its real roots).

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        
        double discriminant = b * b - (4 * a * c);
        double x1;
        double x2;

        if (discriminant < 0)
        {
            Console.WriteLine("The quadratic equation doesn't have real roots");
        }

        else if (discriminant == 0)
        {
            x1 = -b / 2 * a;
            Console.WriteLine("The quadratic equation root is: {0}", x1);
        }

        else
        {
            x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            Console.WriteLine("The roots of the quadratic equation are: {0} , {1}", x1, x2);
        }
    }
}

