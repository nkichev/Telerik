//Write a program that reads a string from the console and prints all different letters in the string along with 
//information how many times each letter is found. 
using System;
using System.Linq;
using System.Collections.Generic;

class PrintDifferentLettersAndHowManyTimes
{
    static void Main()
    {
        string str = @"Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.".ToLower();

        string[] signs = new string[] { ".", ",", "!", "?", " " };

        for (int i = 0; i < signs.Length; i++)
        {
            str = str.Replace(signs[i], string.Empty);
        }

        Dictionary<char, int> letters = new Dictionary<char, int>();

        for (int i = 0; i < str.Length; i++)
        {
            if (letters.ContainsKey(str[i]))
            {
                letters[str[i]]++;
            }
            else
            {
                letters.Add(str[i], 1);
            }
        }
        var sortedDictionary = letters.OrderBy(x => x.Key);

        foreach (var item in sortedDictionary)
        {
            Console.WriteLine("{0} : {1} times", item.Key, item.Value);
        }
    }
}

