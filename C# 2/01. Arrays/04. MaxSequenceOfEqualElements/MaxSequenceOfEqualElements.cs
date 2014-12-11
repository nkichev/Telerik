//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} => {2, 2, 2}.

using System;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        Console.Write("Enter the size of the array : ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        int sequence = 1;
        int maxSequence = 0;
        int element = 0;    

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}] = ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arraySize - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                sequence++;
            }
            if (array[i] != array[i + 1])
            {
                sequence = 1;
            }
            if (sequence > maxSequence)
            {
                maxSequence = sequence;
                element = array[i];
            }
        }

        for (int i = 0; i < maxSequence; i++)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }   
}

