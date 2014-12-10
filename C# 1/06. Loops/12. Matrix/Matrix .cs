//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix.
using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter N (N < 20) : ");
            int N = int.Parse(Console.ReadLine());
            int number = 0;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    Console.Write(j + number + " ");
                }
                number += 1;
                Console.WriteLine();
            }
        }
    }

