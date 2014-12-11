//Write a program for extracting all email addresses from given text. 
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class ExtractAllEmailAddresses
{
    static void Main()
    {
        string str = @"You have been using some@gmail.com in your registration. Don't you prefer to use this one: ppivanov24@abv2.bg";
        string[] newStr = str.Split(' ');

        for (int i = 0; i < newStr.Length; i++)
        {
            if (Regex.IsMatch(newStr[i], @"[\w.,\-]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"))
            {
                Console.WriteLine(newStr[i]);
            }
        }
    }
}

