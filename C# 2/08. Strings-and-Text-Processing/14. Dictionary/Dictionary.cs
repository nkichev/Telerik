//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET
//namespace – hierarchical organization of classes

using System;
using System.Collections.Generic;

class Dictionary
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();

        dict[".NET"] = "platform for applications from Microsoft";
        dict["CLR"] = "managed execution environment for .Net";
        dict["namespace"] = "hierarchical organization of classes";

        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        if (dict.ContainsKey(word))
        {
            Console.WriteLine(dict[word]);
        }
        else
        {
            Console.Write("Enter description: ");
            dict.Add(word, Console.ReadLine());
        }
    }
}

