//Write a program that enters the coefficients a, b and c of a quadratic equation
//a*x2 + b*x + c = 0
//and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Enter a : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c : ");
            double c = double.Parse(Console.ReadLine());
            double x1, x2;
            double discriminant = b * b - (4 * a * c);

            if (discriminant < 0)
            {
                Console.WriteLine("The quadratic equation doesn't have real roots.");
            }
            else if (discriminant == 0)
            {
                x1 = -b / 2 * a;
                Console.WriteLine("The quadratic equation has one root : {0}", x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
                x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
                Console.WriteLine("The roots of the quadratic equation are: {0} , {1}", x1, x2);
            }

        }
    }

