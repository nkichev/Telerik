//Write a program that compares two text files line by line and prints the number of lines that are the same
//and the number of lines that are different. Assume the files have equal number of lines.

using System;
using System.IO;

class SameLinesNumAndDifferentLinesNum
{
    static void Main()
    {
        using (StreamReader firstSr = new StreamReader(@"..\..\Text1.txt"))
        {
            using (StreamReader secondSr = new StreamReader(@"..\..\Text2.txt"))
            {
                string firstSrLine;
                string secondSrLine;

                int differentLines = 0; 
                int sameLines = 0;

                while ((firstSrLine = firstSr.ReadLine()) != null && (secondSrLine = secondSr.ReadLine()) != null)
                {
                    if (firstSrLine == secondSrLine)
                    {
                        sameLines++;
                    }
                    else
                    {
                        differentLines++;
                    }
                }
                Console.WriteLine("Different lines: {0}, same lines: {1}.", differentLines, sameLines);
            }
        }
    }
}

