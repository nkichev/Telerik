namespace Recursion
{
    using System;

    public class CombinationsWithSubset
    {
        /* 05. Write a recursive program for generating and printing all ordered k-element subsets from n-element set (variations Vkn).
        Example: n=3, k=2, set = {hi, a, b} =>
        (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
        */

        private static string[] set = new string[] { "hi", "a", "b" };

        private static int n = 3;
        
        private static int k = 2;
        
        public static void Main()
        {
            string[] array = new string[n];

            GenerateSubSets(array, 0);
        }

        private static void GenerateSubSets(string[] array, int currentindex)
        {
            if (currentindex == k)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                array[currentindex] = set[i];
                GenerateSubSets(array, currentindex + 1);
            }
        }
    }
}