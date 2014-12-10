//Write a program that prints all the numbers from 1 to N.

using System;

class From1toN
{
    static void Main()
    {
        Console.Write("Please enter N : ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i <= N; i++)
        {
            if (i < N)
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write(i);
            }
        }
        Console.WriteLine();
    }
}

