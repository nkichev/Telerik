namespace LinkedListDemo
{
    using System;
    using System.Collections.Generic;

    public class LinkedListDemo
    {
        /* 05. Write a program that removes from given sequence all negative numbers.*/

        public static void Main()
        {
            bool isEmptyLine = false;
            LinkedList<int> sequence = new LinkedList<int>();

            do
            {
                Console.WriteLine("Enter an integer number. Leave blank for end:");
                string line = Console.ReadLine();

                if (string.IsNullOrEmpty(line))
                {
                    isEmptyLine = true;
                    break;
                }

                int currentNumber = int.Parse(line);

                sequence.AddLast(currentNumber);
            }
            while (!isEmptyLine);

            Console.WriteLine("Before: " + string.Join(", ", sequence));
            sequence = RemoveNegativeNumbers(sequence);
            Console.WriteLine("After: " + string.Join(", ", sequence));
        }

        public static LinkedList<int> RemoveNegativeNumbers(LinkedList<int> numbers)
        {
            var node = numbers.First;

            while (node != null)
            {
                var next = node.Next;

                if (node.Value < 0)
                {
                    numbers.Remove(node);
                }

                node = next;
            }

            return numbers;
        }
    }
}