//Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        using (StreamReader rd = new StreamReader(@"..\..\Text1.txt"))
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\Text2.txt"))
            {
                string line = rd.ReadLine();
                int lineNum = 0;

                while (line != null)
                {
                    if ((lineNum % 2) != 0)
                    {
                        sw.WriteLine(line);
                    }
                    line = rd.ReadLine();
                    lineNum++;
                }
            }
        }
        File.Delete(@"..\..\Text1.txt");
        File.Move(@"..\..\Text2.txt", @"..\..\Text1.txt");
    }
}

