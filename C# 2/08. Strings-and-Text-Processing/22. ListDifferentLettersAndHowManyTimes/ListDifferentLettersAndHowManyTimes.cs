//Write a program that reads a string from the console and lists all different 
//words in the string along with information how many times each word is found.
using System;
using System.Collections.Generic;
using System.Linq;

class ListDifferentLettersAndHowManyTimes
{
    static void Main()
    {
        string str = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";

        string[] allWordsArr = str.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> rechnik = new Dictionary<string, int>();

        foreach (var word in allWordsArr)
        {
            if (rechnik.ContainsKey(word))
            {
                rechnik[word]++;
            }
            else 
            {
                rechnik.Add(word, 1);
            }
        }

        var sortedRechnik = rechnik.OrderBy(x => x.Key);

        foreach (var word in sortedRechnik)
        {
            Console.WriteLine("{0,-15} - {1, 15} times", word.Key, word.Value);
        }
    }
}

