//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.

using System;
using System.IO;

class InsertNumbersInFront
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader(@"..\..\Text.txt"))
        {
            int count = 1;
            string line;

            using (StreamWriter sw = new StreamWriter(@"..\..\IndexedText.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    sw.Write("{0}: ", count);
                    sw.WriteLine(line);
                    count++;
                }
            }
        }
    }
}

