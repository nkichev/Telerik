namespace Recursion
{
    using System;

    public class CombinationsWithDuplicates
    {
        /* 02. Write a recursive program for generating and printing all the combinations with duplicates of k elements from n-element set. 
        * Example: n=3, k=2  (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
        */

        public static void Main()
        {
            Console.WriteLine("Please enter n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter k:");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];
            GenerateCombinations(array, k, n, 0);
        }

        private static void GenerateCombinations(int[] array, int k, int n, int currentindex)
        {
            if (currentindex == k)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                array[currentindex] = i + 1;
                GenerateCombinations(array, k, n, currentindex + 1);
            }
        }
    }
}