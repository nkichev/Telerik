//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 
//with a maximal sum of its elements. 
//The first line in the input file contains the size of matrix N. 
//Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file.

using System;
using System.IO;

class ReadMatrixFromFile
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader(@"..\..\matrix.txt"))
        {
            int N = int.Parse(sr.ReadLine());
            int[,] matrix = new int[N, N];
            string line;
            int matrixLine = 0;

            while ((line = sr.ReadLine()) != null)
            {
                string[] nums = line.Split(' ');

                for (int i = 0; i < nums.Length; i++)
                {
                    matrix[matrixLine, i] = int.Parse(nums[i]);
                }
                matrixLine++;
            }

            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestSum)
                        bestSum = sum;
                }

            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                writer.WriteLine(bestSum);
            }
        }
    }
}

