﻿namespace LongestSubsequenceEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestSubsequenceEqualNumbersDemo
    {
        /* 04. Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new List<int>. 
         * Write a program to test whether the method works correctly.*/

        public static void Main()
        {
            var inputSequence = ReadSequence();
            var longestSubsequence = GetLongestSubsequenceWithEqualNumbers(inputSequence);

            Console.WriteLine("Longest Subsequence:");
            foreach (var num in longestSubsequence)
            {
                Console.WriteLine(num);
            }
        }
  
        public static List<int> GetLongestSubsequenceWithEqualNumbers(List<int> inputSequence)
        {
            if (inputSequence == null)
            {
                throw new ArgumentNullException("Input sequence must not be null!");
            }

            if (inputSequence.Count <= 1)
            {
                throw new ArgumentException("Input sequence must contains at least two elements!");
            }

            int maxCount = 0;
            int maxStartIndex = 0;
            int startIndex = 0;
            int count = 1;
            int currentNumber = inputSequence[0];
            for (int i = 1; i < inputSequence.Count; i++)
            {
                if (currentNumber == inputSequence[i])
                {
                    count++;
                    if (count >= maxCount)
                    {
                        maxCount = count;
                        maxStartIndex = startIndex;
                    }
                }
                else
                {
                    count = 1;
                    currentNumber = inputSequence[i];
                    startIndex = i;
                }
            }

            if (maxCount == 0)
            {
                throw new InvalidProgramException("All elements in the input sequence are defferent!");
            }

            List<int> longest = new List<int>();
            for (int i = maxStartIndex; i < maxStartIndex + maxCount; i++)
            {
                longest.Add(inputSequence[i]);   
            }

            return longest;
        }

        private static List<int> ReadSequence()
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

            return sequence;
        }
    }
}