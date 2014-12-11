
namespace CountElements
{
    using System;
    using System.Collections.Generic;

    public static class CountElements
    {
        /* 06. Write a program that removes from given sequence all numbers that occur odd number of times. Example:*/

        public static void Main()
        {
            LinkedList<int> sequence = ReadInputSequence();

            var numbersCounts = CountElementsOccurrence(sequence);
            Console.WriteLine("Before: " + string.Join(", ", sequence));
            sequence = RemoveNumbersOccuringOddTimes(sequence, numbersCounts);
            Console.WriteLine("After: " + string.Join(", ", sequence));
        }
  
        private static LinkedList<int> ReadInputSequence()
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
            return sequence;
        }
  
        public static Dictionary<int, int> CountElementsOccurrence(IEnumerable<int> elements)
        {
            Dictionary<int, int> elementsCount = new Dictionary<int, int>();
            foreach (var num in elements)
            {
                if (elementsCount.ContainsKey(num))
                {
                    elementsCount[num] += 1;
                }
                else
                {
                    elementsCount.Add(num, 1);
                }
            }

            return elementsCount;
        }

        public static LinkedList<int> RemoveNumbersOccuringOddTimes(LinkedList<int> numbers, Dictionary<int, int> numbersCounts)
        {
            var node = numbers.First;

            while (node != null)
            {
                var next = node.Next;
                
                if (numbersCounts[node.Value] % 2 != 0)
                {
                    numbers.Remove(node);
                }

                node = next;
            }

            return numbers;
        }
    }
}