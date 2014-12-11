//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;

class SortingArrayByStringsLength
{
    static void Main()
    {
        Console.Write("Enter the size of the array : ");
        int size = int.Parse(Console.ReadLine());

        string[] array = new string[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = Console.ReadLine();
        }

        //Using lambda expressions
        Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));
        foreach (string element in array)
        {
            Console.WriteLine(element);
        }
    }
}

