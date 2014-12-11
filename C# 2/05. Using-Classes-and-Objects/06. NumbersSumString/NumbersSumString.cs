//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. 
//Example: string = "43 68 9 23 318" => result = 461.

using System;

class NumbersSumString
{
    static void Main()
    {
        Console.Write("Enter numbers: ");
        string numbers = Console.ReadLine();

        int sum = 0;

        string[] strNumbers = numbers.Split(' ');

        for (int i = 0; i < strNumbers.Length; i++)
        {
            sum += int.Parse(strNumbers[i]);
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}

