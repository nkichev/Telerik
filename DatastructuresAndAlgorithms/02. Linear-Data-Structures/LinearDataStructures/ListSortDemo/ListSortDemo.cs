namespace ListSortDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListSortDemo
    {
        /* 03.Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an increasing order. */

        public static void Main()
        {
            bool isEmptyLine = false;
            List<int> sequence = new List<int>();

            do
            {
                Console.WriteLine("Enter a positive integer number. Leave blank for end:");
                string line = Console.ReadLine();

                if (string.IsNullOrEmpty(line))
                {
                    isEmptyLine = true;
                    break;
                }

                int currentNumber = int.Parse(line);

                sequence.Add(currentNumber);
            }
            while (!isEmptyLine);

            if (sequence.Count > 0)
            {
                Console.WriteLine("Ordered sequence:");
                sequence.Sort();
                PrintSequence(sequence);
            }
            else
            {
                Console.WriteLine("The sequence is empty!");
            }
        }

        private static void PrintSequence(List<int> sequence)
        {
            for (int i = 0; i < sequence.Count; i++)
            {
                Console.WriteLine(sequence[i]);
            }
        }
    }
}