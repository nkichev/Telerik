//Write a program that finds the most frequent number in an array. Example:
//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} => 4 (5 times)
//4 4 4 2 6 4 2 4 4 4 4 2 1 2 5 3 6 2 7 1

using System;

class MostFrequentNumber
{
    static void Main()
    {
        Console.Write("Enter the size of the array : ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("myArray[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The array is :");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        int maxCounter = 1;
        int mostFrequent = 0;
        for (int i = 0; i < arraySize - 1; i++)
        {
            int counter = 1;
            for (int j = i + 1; j < arraySize; j++)
            {
                if (array[i] == array[j])
                {
                    counter++;
                }
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
                mostFrequent = array[i];
            }
        }

        if (maxCounter > 1)
        {
            Console.WriteLine("Most frequent number = {0}", mostFrequent);
            Console.WriteLine("Count = {0} times", maxCounter);
        }
        else
        {
            Console.WriteLine("All elements are different");
        }
    }
}

