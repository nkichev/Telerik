//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example: {4, 3, 1, 4, 2, 5, 8}, S=11 => {4, 2, 5}	
using System;

class FindSequenceOfGivenSum
{
    static void Main()
    {
        Console.Write("Enter the size of the array : ");
        int arraySize = int.Parse(Console.ReadLine());

        Console.Write("Enter sum : ");
        int s = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int platformSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        int count = 0;

        Console.WriteLine("The sequence with sum {0} is: ", s);
        for (int i = 0; i < array.Length; i++)
        {
            platformSum = 0;
            for (int j = 0 + i; j < array.Length; j++)
            {
                platformSum += array[j];

                if (platformSum == s)
                {
                    startIndex = i;
                    endIndex = j;
                    count++;


                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(array[k] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("There is no sequence of sum!");
        }
    }
}

