namespace Recursion
{
    using System;

    public class CombinationsNoDuplicates
    {
        /* 03. Modify the previous program to skip duplicates:
        * n=4, k=2  (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
        */

        private static int n;
        
        private static int k;

        private static int[] combination;

        public static void Main()
        {
            Console.WriteLine("Please enter n:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter k:");
            k = int.Parse(Console.ReadLine());

            combination = new int[k];

            GenerateCombinations(1, 0);
        }

        private static void GenerateCombinations(int level, int next)
        {
            if (level > k)
            {
                return;
            }

            for (int i = next + 1; i <= n; i++)
            {
                combination[level - 1] = i;
                if (level == k)
                {
                    Console.WriteLine(string.Join(" ", combination));
                }

                GenerateCombinations(level + 1, i);
            }
        }
    }
}