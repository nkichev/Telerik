//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements 
//located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 

using System;

class LongestSecOfEqualStrings
{
    static void Main()
    {
        // ds sd ad fg
        // as s  ds hg
        // sd lk s  vb
        // hj gh bv s

        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());


        string[,] matrix = new string[n, m];

        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < m; cols++)
            {
                Console.Write("matrix[{0}, {1}] = ", rows, cols);
                matrix[rows, cols] = Console.ReadLine();
            }
        }

        int counter = 1;
        int bestCounter = int.MinValue;
        string element = "";

        //searching horizontal
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    counter++;

                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        element = matrix[row, col];
                    }
                }
            }
            counter = 1;
        }

        //searching vertical
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    counter++;

                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        element = matrix[row, col];
                    }
                }
            }
            counter = 1;
        }

        //searching in diagonal from top left to bottom right.

        for (int col = 0, row = 0; col < matrix.GetLength(1) - 1 && row < matrix.GetLength(0) - 1; col++, row++)
        {
            if (matrix[row, col] == matrix[row + 1, col + 1])
            {
                counter++;

                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    element = matrix[row, col];
                }
            }
            else
            {
                counter = 1;
            }
        }
        counter = 1;

        //searching in diagonal from top right to bottom left.

        for (int row = 0, col = matrix.GetLength(1) - 1; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
        {
            if (matrix[row, col] == matrix[row + 1, col - 1])
            {
                counter++;

                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    element = matrix[row, col];
                }
            }
            else
            {
                counter = 1;
            }
        }
        counter = 1;

        for (int i = 0; i < bestCounter; i++)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

