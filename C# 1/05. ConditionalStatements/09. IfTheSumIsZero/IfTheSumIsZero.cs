//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
//Example: 3, -2, 1, 1, 8 => 1+1-2=0.

using System;

    class IfTheSumIsZero
    {
        static void Main()
        {
            Console.Write("Enter first number : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter first number : ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter first number : ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Enter first number : ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Enter first number : ");
            double e = double.Parse(Console.ReadLine());
            bool subsetZero = false;

            if ((a + b == 0) || (a + c == 0) || (a + d == 0) ||
            (a + e == 0) || (b + c == 0) || (b + d == 0) ||
            (b + e == 0) || (c + d == 0) || (c + e == 0) ||
            (d + e == 0) || (a + b + c == 0) || (a + b + d == 0) ||
            (a + b + e == 0) || (a + c + d == 0) || (a + c + e == 0) ||
            (a + d + e == 0) || (b + c + d == 0) || (b + c + e == 0) ||
            (b + d + e == 0) || (c + d + e == 0) || (a + b + c + d == 0) ||
            (a + b + c + e == 0) || (a + c + d + e == 0) || (b + c + d + e == 0) ||
            (a + b + c + d + e == 0))
            {
                subsetZero = true;
                Console.WriteLine("Is there any subset sum = 0 ? {0}", subsetZero);
            }
            else
            {
                Console.WriteLine("Is there any subset sum = 0 ? {0}", subsetZero);
            }
            
        }
    }

