//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. Example:
//"Microsoft announced its next generation PHP compiler today. It is based on .NET 
//Framework 4.0 and is implemented as a dynamic language in CLR."
//Words: "PHP, CLR, Microsoft"
//The expected result:
//"********* announced its next generation *** compiler today. It is based on .NET 
//Framework 4.0 and is implemented as a dynamic language in ***."
using System;
using System.Text;

class ReplaceForbiddenWordsWithAsterisks
{
    static void Main()
    {
        StringBuilder text = new StringBuilder ("Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.");
        string words = "PHP, CLR, Microsoft";

        string[] wordsArr = words.Split(',');

        for (int i = 0; i < wordsArr.Length; i++)
        {
            wordsArr[i] = wordsArr[i].Trim();
            text = text.Replace(wordsArr[i], new string('*', wordsArr[i].Length));
        }

        Console.WriteLine(text);
    }
}

