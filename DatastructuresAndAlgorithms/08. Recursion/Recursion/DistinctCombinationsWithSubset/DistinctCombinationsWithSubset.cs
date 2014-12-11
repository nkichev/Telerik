namespace Recursion
{
    using System;

    public class DistinctCombinationsWithSubset
    {
        /* 06. Write a program for generating and printing all subsets of k strings from given set of strings.
        Example: s = {test, rock, fun}, k=2
        (test rock),  (test fun),  (rock fun)
        */

        private static int k = 2;
        
        private static string[] set = new string[] { "test", "rock", "fun" };
        
        private static string[] combination = new string[k];

        public static void Main()
        {
            GenerateCombinations(1, 0);
        }

        private static void GenerateCombinations(int level, int next)
        {
            if (level > k)
            {
                return;
            }

            for (int i = next + 1; i <= set.Length; i++)
            {
                combination[level - 1] = set[i - 1];
                if (level == k)
                {
                    Console.WriteLine(string.Join(" ", combination));
                }

                GenerateCombinations(level + 1, i);
            }
        }
    }
}