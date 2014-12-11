//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.IO;

class ReadAndPrintOddLines
{
    static void Main()
    {
        using (StreamReader rd = new StreamReader(@"..\..\test.txt"))
        {
            string line = rd.ReadLine();
            int lineNum = 1;

            while (line != null)
            {
                if ((lineNum % 2) != 0)
                {
                    Console.WriteLine(line);
                }

                line = rd.ReadLine();
                lineNum++;
            }
        }
    }
}

