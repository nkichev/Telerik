//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWordStartingWithTest
{
    static void Main()
    {
        string line = "";
        using (StreamReader sr = new StreamReader(@"..\..\text.txt"))
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\result.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    line = Regex.Replace(line, @"\btest\w*(\s|\S)\b", "");
                    sw.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
        }
    }
}

