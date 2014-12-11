//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractAllDatesMatchingTheFormat
{
    static void Main()
    {
        string str = @"You have been there on 15.03.2004 , but now it's 16.06.2006 . Where you'll be on 6.6.2009 ?";
        string[] newStr = str.Split(' ');

        for (int i = 0; i < newStr.Length; i++)
        {
            if (Regex.IsMatch(newStr[i], @"\b\d{2}.\d{2}.\d{4}\b"))
            {
                DateTime date = DateTime.Parse(newStr[i]);
                Console.WriteLine(newStr[i].ToString(CultureInfo.GetCultureInfo("en-CA")));

            }
        }
    }
}