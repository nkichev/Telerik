//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!" => "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Text;

class ReverseTheWords
{
    static void Main()
    {
        string str = "C# is not C++, not PHP and not Delphi!";

        char[] splitChars = new char[] {' ', ',', '!', '.'};
        string[] words = str.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
        string[] signs = str.Split(words, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);

        StringBuilder newStr = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            newStr.Append(words[i] + signs[i]);
        }

        Console.WriteLine(newStr.ToString());
    }
}

