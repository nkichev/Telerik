﻿//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
//Hi!

//Expected output:
//\u0048\u0069\u0021

using System;

class ConvertStringToUnicodeLiterals
{
    static void Main()
    {
        string str = "Hi!";

        foreach (var symbol in str)
        {
            Console.Write("\\u{0:X4}", (int)symbol);
        }
        Console.WriteLine();
    }
}

