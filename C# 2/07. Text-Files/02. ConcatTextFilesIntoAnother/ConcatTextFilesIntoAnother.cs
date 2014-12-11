//Write a program that concatenates two text files into another text file.

using System;
using System.IO;

class ConcatTextFilesIntoAnother
{
    static void Main()
    {
        using (StreamWriter sw = new StreamWriter(@"..\..\FullText.txt"))
        {
            using (StreamReader firstSr = new StreamReader(@"..\..\Text1.txt"))
            {
                string line = firstSr.ReadToEnd();
                sw.Write(line);
            }
            using (StreamReader secondSr = new StreamReader(@"..\..\Text2.txt"))
            {
                string line = secondSr.ReadLine();
                sw.Write(line);
            }
        }
    }
}

