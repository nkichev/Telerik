namespace Recursion
{
    using System;
    using System.Collections.Generic;

    public class CheckIfPathExists
    {
        /* 08. Modify the above program to check whether a path exists between two cells without finding all possible paths. Test it over an empty 100 x 100 matrix.*/
        
        private static char[,] matrix = new char[,]
        {
            { ' ', ' ', ' ', '*', ' ', ' ', 'e' },
            { '*', '*', ' ', '*', ' ', '*', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', '*', '*', '*', '*', '*', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
        };

        private static bool hasExit = false;

        private static List<Tuple<int, int>> currentPath = new List<Tuple<int, int>>();

        public static void Main()
        {
            FindPath(0, 0);

            if (hasExit)
            {
                Console.WriteLine("Path exists!");
            }
            else
            {
                Console.WriteLine("Path does not exists!");
            }
        }

        private static void FindPath(int startX, int startY)
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

            // Path found!
            if (matrix[startX, startY] == 'e')
            {
                hasExit = true;
                currentPath.Add(new Tuple<int, int>(startX, startY));
            }

            // Add to path and mark as visited.
            currentPath.Add(new Tuple<int, int>(startX, startY));
            matrix[startX, startY] = 'v';

            // Go up
            FindPath(startX - 1, startY);

            // Go down
            FindPath(startX + 1, startY);

            // Go left
            FindPath(startX, startY - 1);

            // Go right
            FindPath(startX, startY + 1);
        }
    }
}