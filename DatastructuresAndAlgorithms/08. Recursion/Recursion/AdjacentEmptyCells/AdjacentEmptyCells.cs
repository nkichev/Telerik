namespace Recursion
{
    using System;
    using System.Collections.Generic;

    public class AdjacentEmptyCells
    {
        /* 09. Write a recursive program to find the largest connected area of adjacent empty cells in a matrix.*/

        private static char[,] matrix = new char[,]
        {
            { ' ', ' ', ' ', '*', ' ', ' ', 'e' },
            { '*', '*', ' ', '*', ' ', '*', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', '*', '*', '*', '*', '*', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
        };

        private static List<Tuple<int, int>> currentPath = new List<Tuple<int, int>>();

        private static List<Tuple<int, int>> maxPath = new List<Tuple<int, int>>();

        public static void Main()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == ' ')
                    {
                        currentPath.Clear();
                        FindAllPaths(row, col);
                        if (currentPath.Count > maxPath.Count)
                        {
                            maxPath = currentPath;
                        }
                    }
                }
            }

            PrintPath(maxPath);
        }

        private static void FindAllPaths(int startX, int startY)
        {
            // Check if out of matrix.
            if (startX < 0 || startY < 0 || startX >= matrix.GetLength(0) || startY >= matrix.GetLength(1))
            {
                return;
            }

            if (matrix[startX, startY] == '*' || matrix[startX, startY] == 'v')
            {
                return;
            }

            // Add to path and mark as visited.
            currentPath.Add(new Tuple<int, int>(startX, startY));
            matrix[startX, startY] = 'v';

            // Go up
            FindAllPaths(startX - 1, startY);

            // Go down
            FindAllPaths(startX + 1, startY);

            // Go left
            FindAllPaths(startX, startY - 1);

            // Go right
            FindAllPaths(startX, startY + 1);
        }

        private static void PrintPath(List<Tuple<int, int>> currentPath)
        {
            Console.WriteLine("Longest connected area:");
            foreach (var step in currentPath)
            {
                Console.Write("({0}, {1})", step.Item1, step.Item2);
            }

            Console.WriteLine();
        }
    }
}