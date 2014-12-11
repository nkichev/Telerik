﻿//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinToHexDirectly
{
    static void Main()
    {
        Console.Write("Enter the binary number: ");
        string binNum = Console.ReadLine();

        string result = "";

        //add zeroes if the number of the digits is not 4.
        for (int i = 4; i < 32; i *= 4)
        {
            if (binNum.Length < i)
            {
                string leadingZeros = new String('0', i - binNum.Length);
                binNum = leadingZeros + binNum;
                break;
            }
        }

        for (int i = 0; i < binNum.Length; i += 4)
        {
            switch (binNum.Substring(i, 4))
            {
                case "0000": result += "0"; break;
                case "0001": result += "1"; break;
                case "0010": result += "2"; break;
                case "0011": result += "3"; break;
                case "0100": result += "4"; break;
                case "0101": result += "5"; break;
                case "0110": result += "6"; break;
                case "0111": result += "7"; break;
                case "1000": result += "8"; break;
                case "1001": result += "9"; break;
                case "1010": result += "A"; break;
                case "1011": result += "B"; break;
                case "1100": result += "C"; break;
                case "1101": result += "D"; break;
                case "1110": result += "E"; break;
                case "1111": result += "F"; break;
                default: result += ""; break;
            }
        }
        Console.WriteLine("The hexadecimal representation of the number is: {0}", result);
    }
}

