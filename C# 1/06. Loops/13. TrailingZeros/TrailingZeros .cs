//Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
//	N = 10 => N! = 3628800 => 2
//	N = 20 => N! = 2432902008176640000 => 4
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N : ");
        int N = int.Parse(Console.ReadLine());

        int zeroesCount = 0;
        int divider = 5;

        while (N >= divider)
        {
            zeroesCount += (N / divider);
            divider *= 5;
        }
        Console.WriteLine("Trailing zeroes : {0}", zeroesCount);
    }
}

