//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceStartWithFinish
{
    static void Main()
    {
        string start = "start";
        string finish = "finish";

        using (StreamReader sr = new StreamReader(@"..\..\Text1.txt"))
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\Text2.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Replace(start, finish);
                    sw.WriteLine(line);
                    line = sr.ReadLine();
                }
            }
        }
        File.Delete(@"..\..\Text1.txt");
        File.Move(@"..\..\Text2.txt", @"..\..\Text1.txt");
    }
}

