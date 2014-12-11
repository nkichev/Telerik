//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;

class Palindromes
{
    static void Main()
    {
        string str = "Alula. I'm dating Anna tomorrow. My new Honda Civic! Do you love your kayak?".ToLower();

        char[] splitChars = new char[] { ' ', '.', ',', '!', '?', '\n', '\r' };

        string[] newStr = str.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in newStr)
        {
            bool isPal = true;
            for (int j = 0; j < (word.Length / 2); j++)
            {
                if (word[j] != word[word.Length - 1 - j])
                {
                    isPal = false;
                    break;
                }
            }
            if (isPal)
            {
                Console.WriteLine(word);
            }
        }



//        string text = @"Nice blue sky. No exe flying in the sky. ABBA will not come in Bulgaria.
//       I don`t know what is lamal, maybe I will find some day. mouseesuom";
//        char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
//        string[] splitted = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);


//        foreach (string word in splitted)
//        {
//            bool isPalindrome = true;
//            for (int j = 0; j < (word.Length / 2); j++)
//            {
//                if (word[j] != word[word.Length - 1 - j])
//                {
//                    isPalindrome = false;
//                    break;
//                }
//            }
//            if (isPalindrome && word.Length > 1)
//            {
//                Console.WriteLine(word);
//            }
//        }
    }
}

