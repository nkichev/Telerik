//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. 
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first 
//of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodingAndDecoding
{
    static void Main()
    {
        string text = Console.ReadLine();
        string key = "abcd";

        string encryptedText = EncryptingText(text, key);
        Console.WriteLine(encryptedText);

        string decryptedText = DecryptingText(EncryptingText(text, key), key);
        Console.WriteLine(decryptedText);
    }

    static string EncryptingText(string text, string key)
    {
        StringBuilder newText = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        newText.Append((char)(text[i] ^ (key[i % key.Length])));

        return newText.ToString();
    }

    static string DecryptingText(string text, string key)
    { 
        return EncryptingText(text, key);
    }
}

