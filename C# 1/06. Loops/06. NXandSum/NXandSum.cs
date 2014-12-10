//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class NXandSum
{
    static void Main()
    {
        Console.Write("Enter N = ");
        double N = double.Parse(Console.ReadLine());
        Console.Write("Enter X = ");
        double X = double.Parse(Console.ReadLine());
 
        double nProduct = 1;
        double sum = 1;

        for (int i = 1; i <= N; i++)
        {
            nProduct *= i;
        }

        double nxProduct = nProduct / (X * N);
        
        nProduct = 1;

        for (int i = 1; i <= N; i++)
        {
            nProduct *= i;
            sum += (nProduct / (X * i));
        }

        Console.WriteLine("S = {0}", sum);
    }
}

