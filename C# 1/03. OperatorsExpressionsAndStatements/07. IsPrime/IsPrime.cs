//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class IsPrime
{
    static void Main()
    {
        Console.WriteLine("Enter a number (<=100): " );
        int n = int.Parse(Console.ReadLine());
        int divider = 2;
        int maxDivider = (int)Math.Sqrt(n);
        bool prime = true;
        while (prime && (divider <= maxDivider))
        {
            if (n % divider == 0)
            {
                prime = false;
            }
            divider++;
        }
        Console.WriteLine("Is number prime?" + " " + prime);
    }
}

