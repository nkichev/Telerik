//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
//Ivan			George
//Peter			Ivan
//Maria	  ===>	Maria
//George		Peter

using System;
using System.Collections.Generic;
using System.IO;

class ReadStringsAndSortThem
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader(@"..\..\strings.txt"))
        {
            List<string> strings = new List<string>();

            for (string currentString = sr.ReadLine(); currentString != null; currentString = sr.ReadLine())
            {
                strings.Add(currentString);
            }

            strings.Sort();

            using (StreamWriter sw = new StreamWriter(@"..\..\SortedStrings.txt"))
            {
                foreach (string item in strings)
                {
                    sw.WriteLine(item);
                }
            }
        }
    }
}

