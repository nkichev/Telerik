//Modify the solution of the previous problem to replace only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class PreviousExerciseModified
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader(@"..\..\Text1.txt"))
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\Text2.txt"))
            {
                Regex regex = new Regex(@"\b(start)\b");

                for (string line = sr.ReadLine(); line != null; line = sr.ReadLine())
                {
                    string modifiedLine = regex.Replace(line, "finish");
                    sw.WriteLine(modifiedLine);
                }
            }
        }
        File.Delete(@"..\..\Text1.txt");
        File.Move(@"..\..\Text2.txt", @"..\..\Text2.txt");
    }
}

