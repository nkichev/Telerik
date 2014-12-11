namespace Recursion
{
    using System;

    public class PermutationGeneration
    {
        /* 04. Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number n. 
        * Example: n=3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}*/

        private static int n;

        private static int[] permutation;
        
        private static bool[] used;

        public static void Main()
        {
            Console.WriteLine("Please enter n:");
            n = int.Parse(Console.ReadLine());

            permutation = new int[n];
            used = new bool[n];
            
            Permute(0);
        }

        private static void Permute(int currentindex)
        {
            if (currentindex >= n)
            {
                Console.WriteLine(string.Join(" ", permutation));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    permutation[currentindex] = i + 1;
                    Permute(currentindex + 1);
                    used[i] = false;
                }
            }
        }
    }
}