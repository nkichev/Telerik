//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> 
//to uppercase. The tags cannot be nested. Example:

//"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else."

//The expected result:

//"We are living in a YELLOW SUBMARINE. We don't have ANYTHING else."

using System;

class UpcaseTag
{
    static void Main()
    {
        Console.Write("Enter some text: ");
        string text = Console.ReadLine();

        string tagOpen = "<upcase>";
        string tagClose = "</upcase>";

        while (text.IndexOf(tagOpen) != -1)
        {
            int tagOpenIndex = text.IndexOf(tagOpen);
            int tagCloseIndex = text.IndexOf(tagClose);
            string innerText = text.Substring(tagOpenIndex + tagOpen.Length, tagCloseIndex - (tagOpenIndex + tagOpen.Length));
            text = text.Replace(tagOpen + innerText + tagClose, innerText.ToUpper());
        }

        Console.WriteLine(text);
    }
}

