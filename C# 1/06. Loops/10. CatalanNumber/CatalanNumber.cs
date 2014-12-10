//Write a program to calculate the Nth Catalan number by given N.
//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
// Cn = (2n)! / (n + 1)!n!

using System;

class CatalanNumber
{
    static void Main()
    {
        Console.Write("Enter N : ");
        double N = double.Parse(Console.ReadLine());

        double nProduct = 1;
        for (double i = 1; i <= N; i++)
        {
            nProduct *= i;
        }

        double nProduct2 = 2 * N;
        for (int i = 1; i < 2 * N; i++)
        {
            nProduct2 *= i;
        }

        double nProduct3 = 1;
        for (int i = 1; i <= N + 1; i++)
        {
            nProduct3 *= i;
        }

        double catalanNumber = nProduct2 / (nProduct3 * nProduct);
        Console.WriteLine("Catalan number = {0}", catalanNumber);   
    }
}

