//Write a program that extracts from given XML file all the text without the tags. Example:
//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest> Games</instrest>
//<interest>C#</instrest><interest> Java</instrest></interests></student>

using System;
using System.IO;
using System.Text.RegularExpressions;

class ExtractTextWithoutTags
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader(@"..\..\Text.txt"))
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\Result.txt"))
            {
                string text = sr.ReadToEnd();
                string newText = Regex.Replace(text, "<(.*?)>", " ");
                sw.WriteLine(newText.Trim());
            }
        }
    }
}

