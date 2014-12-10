//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;
using System.Linq;

class MinAndMax
{
    static void Main()
    {
        Console.Write("Please enter N : ");
        int N = int.Parse(Console.ReadLine());

        int[] numbers = new int[N];

        for (int i = 0; i < N; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The maximal number is : {0}", numbers.Max());
        Console.WriteLine("The minimal number is : {0}", numbers.Min());
    }
}

