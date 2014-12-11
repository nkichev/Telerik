////Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
//7  11  14  16
//4  8   12  15
//2  5   9   13
//1  3   6   10

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        int counter = 1;

        // Fill Matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col <= row; col++)
            {
                matrix[n - row + col - 1, col] = counter++;
            }
        }

        for (int row = n - 2; row >= 0; row--)
        {
            for (int col = row; col >= 0; col--)
            {
                matrix[row - col, n - col - 1] = counter++;
            }
        }

        // Print Matrix
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

