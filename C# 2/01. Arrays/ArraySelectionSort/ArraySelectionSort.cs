//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class ArraySelectionSort
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

        int keepValue;
        for (int i = 0; i < array.Length - 1; i++)
        {
            int smallestElement = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < smallestElement)
                {
                    smallestElement = array[j];
                    keepValue = array[i];
                    array[i] = array[j];
                    array[j] = keepValue;
                }
            }
        }
        Console.WriteLine();

        Console.WriteLine("After applying \"selection sort\" the array looks like: ");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}

