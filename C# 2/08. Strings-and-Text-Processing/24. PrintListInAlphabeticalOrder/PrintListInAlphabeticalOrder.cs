//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class PrintListInAlphabeticalOrder
{
    static void Main()
    {
        string str = "Write a program that reads a list of words separated by spaces and prints the list in an alphabetical order";

        string[] newStr = str.Split();

        Array.Sort(newStr);

        foreach (var item in newStr)
        {
            Console.Write("{0} ", item);
        }
    }
}

