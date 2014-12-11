//Write a program that finds the sequence of maximal sum in given array. Example:
//{2, 3, -6, -1, 2, -1, 6, 4, -8, 8} => {2, -1, 6, 4}

using System;

    class SequenceOfMaxSum
    {
        static void Main()
        {
            Console.Write("Enter the size of the array : ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize]; 

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("myArray[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The array is:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            int bestSum = int.MinValue;
            int tempSum = 0;
            int startIndex = 0;
            int lastIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                tempSum += array[i];

                if (array[i] > tempSum)
                {
                    tempSum = array[i];
                    startIndex = i;
                }

                if (tempSum > bestSum)
                {
                    bestSum = tempSum;
                    lastIndex = i;
                }
            }

            Console.WriteLine("The Max sum of sequence is {0} and the members are:", bestSum);
            for (int i = startIndex; i <= lastIndex; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }

