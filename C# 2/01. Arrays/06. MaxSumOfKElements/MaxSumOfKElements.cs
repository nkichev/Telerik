//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaxSumOfKElements
{
    static void Main()
    {
        Console.Write("Enter n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k = ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("array[{0}] = ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        string bestSeq = "";
        int sum = 0;
        int bestSum = int.MinValue;
        int arrayLength = array.Length;

        for (int i = 0; i < arrayLength; i++)
        {
            string currentSeq = "";
            if (i + k > arrayLength)
            {
                break;
            }

            for (int j = i; j < i + k; j++)
            {
                sum = sum + array[j];
                currentSeq += array[j] + " ";
            }

            if (sum > bestSum)
            {
                bestSeq = currentSeq;
                bestSum = sum;
            }
            sum = 0;
        }
        Console.WriteLine(bestSeq);
        Console.WriteLine(bestSum);
    }
}

