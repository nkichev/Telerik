//Write a program that extracts from a given text all sentences containing given word.
//Example: The word is "in". The text is:
//"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days."
//The expected result is:
//"We are living in a yellow submarine.
//We will move out of it in 5 days."
//Consider that the sentences are separated by "." and the words – by non-letter symbols.
using System;
using System.Text.RegularExpressions;

class ExtractSentencesContainingTheWord
{
    static void Main()
    {
        string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight." +
            "So we are drinking all the day. We will move out of it in 5 days.";

        string word = "in";

        //string[] sentences = str.Split('.');

        //for (int i = 0; i < sentences.Length; i++)
        //{
        //    if (Regex.IsMatch(sentences[i], @"\b" + word + @"\b\.?", RegexOptions.IgnoreCase))
        //    {
        //        Console.WriteLine(sentences[i].Trim());
        //    }
        //}

        string[] sentences = str.Split('.');

        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].ToLower().Contains("in ") || sentences[i].ToLower().Contains(" in ") || sentences[i].ToLower().Contains("in."))
            {
                Console.WriteLine(sentences[i].Trim());
            }
        }
    }
}

