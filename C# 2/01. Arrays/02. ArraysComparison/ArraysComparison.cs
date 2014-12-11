//Write a program that reads two arrays from the console and compares them element by element.

using System;

class ArraysComparison
{
    static void Main()
    {
        Console.Write("Enter the size of the first array: ");
        int firstArraySize = int.Parse(Console.ReadLine());
        Console.Write("Enter the size of the second array: ");
        int secondArraySize = int.Parse(Console.ReadLine());

        int[] firstArray = new int[firstArraySize];
        int[] secondArray = new int[secondArraySize];

        bool areEqual = true;

        if (firstArraySize != secondArraySize)
        {
            areEqual = false;
        }
        else
        {
            for (int i = 0; i < firstArraySize; i++)
            {
                Console.Write("firstArray[{0}] = ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
                Console.Write("secondArray[{0}] = ", i);
                secondArray[i] = int.Parse(Console.ReadLine());

                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                }
                else
                {
                    areEqual = true;
                }
            }
        }
        Console.WriteLine("Are equal ? : {0}", areEqual);
    }
}

