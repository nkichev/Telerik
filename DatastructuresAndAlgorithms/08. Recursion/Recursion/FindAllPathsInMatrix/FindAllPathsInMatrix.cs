namespace FindAllPathsInMatrix
{
    using System;
    using System.Collections.Generic;

    public class FindAllPathsInMatrix
    {
        /* 07. We are given a matrix of passable and non-passable cells. Write a recursive program for finding all paths between two cells in the matrix.*/

        private static char[,] matrix = new char[,]
        {
            { ' ', ' ', ' ', '*', ' ', ' ', 'e' },
            { '*', '*', ' ', '*', ' ', '*', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', '*', '*', '*', '*', '*', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
        };

        private static List<Tuple<int, int>> currentPath = new List<Tuple<int, int>>();

        public static void Main()
        {
            FindAllPaths(0, 0);
        }

        private static void FindAllPaths(int startX, int startY)
        {
            if (startX < 0 || startY < 0 || startX >= matrix.GetLength(0) || startY >= matrix.GetLength(1))
            {
                return;
            }

            if (matrix[startX, startY] == '*' || matrix[startX, startY] == 'v')
            {
                return;
            }

            if (matrix[startX, startY] == 'e')
            {
                currentPath.Add(new Tuple<int, int>(startX, startY));
                PrintPath(currentPath);
                currentPath.RemoveAt(currentPath.Count - 1);
                return;
            }

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

            matrix[startX, startY] = ' ';
            currentPath.RemoveAt(currentPath.Count - 1);
        }

        private static void PrintPath(List<Tuple<int, int>> currentPath)
        {
            Console.WriteLine("Path to the exit:");
            foreach (var step in currentPath)
            {
                Console.Write("({0}, {1})", step.Item1, step.Item2);
            }

            Console.WriteLine();
        }
    }
}