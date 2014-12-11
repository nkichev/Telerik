//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
//1  12  11  10
//2  13  16  9
//3  14  15  8
//4  5   6   7

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        string direction = "down";
        int currentRow = 0;
        int currentCol = 0;

        for (int i = 1; i <= n * n; i++)
        {

            if (direction == "down" && (currentRow >= n || matrix[currentRow, currentCol] != 0) )
            {
                currentRow--;
                currentCol++;
                direction = "right";
            }
            else if (direction == "right" && (currentCol >= n || matrix[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow--;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || matrix[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || matrix[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow++;
                direction = "down";
            }

            matrix[currentRow, currentCol] = i;

            if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
            else if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }

        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }
}

