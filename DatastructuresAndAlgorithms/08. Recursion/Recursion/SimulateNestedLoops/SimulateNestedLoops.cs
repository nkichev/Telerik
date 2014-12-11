namespace Recursion
{
    using System;

    public class SimulateNestedLoops
    {
        /* 01. Write a recursive program that simulates the execution of n nested loops from 1 to n.*/

        public static void Main()
        {
            Console.WriteLine("Please enter n:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            SimulateNestedLoop(array, n, 0);
        }

        private static void SimulateNestedLoop(int[] array, int count, int currentindex)
        {
            if (currentindex == count)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }

            for (int i = 0; i < count; i++)
            {
                array[currentindex] = i + 1;
                SimulateNestedLoop(array, count, currentindex + 1);
            }
        }
    }
}