//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaxSum3x3
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, M];
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        int k = 3;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write("matrix[{0}, {1}] = ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int row = 0; row < N - (k - 1); row++)
        {
            for (int col = 0; col < M - (k - 1); col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        int[,] result = new int[k, k];

        Console.WriteLine("Best platform is:");
        for (int i = 0; i < k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                result[i, j] = matrix[bestRow + i, bestCol + j];
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Best sum = {0}", bestSum);

    }
}

