//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
//1 8 9  16
//2 7 10 15
//3 6 11 14
//4 5 12 13

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int col = 0, counter = 1; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            
        }
        Console.WriteLine();
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

