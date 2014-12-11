
namespace CountArrayElements
{
    using System;
    using CountElements;

    
    public class CountArrayElements
    {
        /* 07. Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
        Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
        2 -> 2 times
        3 -> 4 times
        4 -> 3 times */

        public static void Main()
        {
            int[] elements = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            var elementsCounts = CountElements.CountElementsOccurrence(elements);

            Console.WriteLine("Elements: " + string.Join(", ", elements));

            foreach (var element in elementsCounts)
            {
                Console.WriteLine("{0} -> {1} {2}", element.Key, element.Value, element.Value == 1 ? "time" : "times");
            }
        }
    }
}