//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
//1 5 9  13
//2 6 10 14
//3 7 11 15
//4 8 12 16

using System;

class FillAMatrix
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int col = 0, counter = 1; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = counter;
                counter++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}

