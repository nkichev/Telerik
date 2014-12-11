//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample" => "elpmas".
using System;
using System.Text;

class PrintReversedString
{
    static void Main()
    {
        Console.Write("Enter some text: ");
        string str = Console.ReadLine();

        StringBuilder reversedStr = new StringBuilder();

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversedStr.Append(str[i]);
        }

        Console.WriteLine("The reversed text is: {0}", reversedStr);
    }
}

