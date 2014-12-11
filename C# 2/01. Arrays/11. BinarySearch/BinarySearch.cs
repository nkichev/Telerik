//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter the size of the array : ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        Console.WriteLine("After sorting the array looks like :");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.Write("Enter the number that we are searching for : ");
        int searchedNumber = int.Parse(Console.ReadLine());

        int startSearch = 0;
        int endSearch = arraySize - 1;
        int middle;

        while (startSearch <= endSearch)
        {
            middle = (startSearch + endSearch) / 2;

            if (array[middle] == searchedNumber)
            {
                Console.WriteLine("Index is: {0}", middle);
                break;
            }

            if (array[middle] < searchedNumber)
            {
                startSearch = middle + 1;
            }

            if (array[middle] > searchedNumber)
            {
                endSearch = middle - 1;
            }
        }
    }
}

