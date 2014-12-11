//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} => {2, 3, 4}.

using System;

class MaxIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter the size of the array = ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        int sequence = 1;
        int maxSequence = 1;
        int element = 0;
        int element1 = 0;

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}] = ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < arraySize; i++)
        {
            if (array[i - 1] == array[i] - 1)
            {
                sequence++;
                element1 = array[i];
            }
            else if (array[i - 1] != array[i] - 1 && maxSequence < sequence)
            {
                maxSequence = sequence;
                element = element1;
                sequence = 1;
                element1 = 0;
            }
            else 
            {
                sequence = 1;
                element1 = 0;
            }
        }

        element -= maxSequence - 1;

        for (int i = 0; i < maxSequence; i++)
        {
            Console.Write(element + " ");
            element++;
        }
    }
}

