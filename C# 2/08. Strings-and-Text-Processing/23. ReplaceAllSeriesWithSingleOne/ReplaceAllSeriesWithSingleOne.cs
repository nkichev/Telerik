//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a 
//single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
using System;
using System.Text;

class ReplaceAllSeriesWithSingleOne
{
    static void Main()
    {
        string str = "aaaaabbbbbcdddeeeedssaa";

        StringBuilder newStr = new StringBuilder();

        newStr.Append(str[0]);

        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] != newStr[newStr.Length - 1])
            {
                newStr.Append(str[i]);
            }
        }

        Console.WriteLine(newStr.ToString());
    }
}

