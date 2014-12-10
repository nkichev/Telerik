//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

using System;

class NotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Please enter N : ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i <= N; i++)
        {
            if (i % 21 != 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine();
    }
}

