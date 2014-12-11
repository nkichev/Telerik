//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first char elements:");
        string firstChars = Console.ReadLine();
        char[] firstArray = firstChars.ToCharArray(); 
        int firstArrayLength = firstArray.Length; 

        Console.WriteLine("Enter the second char elements:");
        string secondChars = Console.ReadLine();
        char[] secondArray = secondChars.ToCharArray();
        int secondArrayLength = secondArray.Length;

        int minLength = Math.Min(secondArrayLength, firstArrayLength); 

        bool equalCharArrays = true;

        for (int i = 0; i < minLength; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                continue;
            }
            else
            {
                equalCharArrays = false;
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("The first array is lexicografically before the second.");
                }
                else
                {
                    Console.WriteLine("The second array is lexicografically before the first.");
                }
                break;
            }
        }
        if (equalCharArrays == true && firstArrayLength < secondArrayLength)
        {
            Console.WriteLine("The first array is lexicografically before the second.");
        }
        else if (equalCharArrays == true && firstArrayLength > secondArrayLength)
        {
            Console.WriteLine("The second array is lexicografically before the first.");
        }
        else if (equalCharArrays == true && firstArrayLength == secondArrayLength)
        {
            Console.WriteLine("The arrays are equal.");
        }
    }
}

