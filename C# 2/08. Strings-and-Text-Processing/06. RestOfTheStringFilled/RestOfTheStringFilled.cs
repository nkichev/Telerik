//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.

using System;

class RestOfTheStringFilled
{
    static void Main()
    {
        Console.Write("Enter string with no more than 20 characters: ");
        string str = Console.ReadLine();
        int length = 20;
        string newStr = "";

        if (str.Length < length)
        {
            newStr = str.PadRight(length, '*');
        }

        Console.WriteLine(newStr);
    }
}

