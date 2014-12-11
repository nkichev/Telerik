//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecToHex
{
    static void Main()
    {
        Console.Write("Enter the decimal number: ");
        int decNum = int.Parse(Console.ReadLine());

        int remainder = decNum % 16;
        string result = "";

        while (decNum > 0)
        {
            switch (remainder)
            {
                case 10: result += "A"; break;
                case 11: result += "B"; break;
                case 12: result += "C"; break;
                case 13: result += "D"; break;
                case 14: result += "E"; break;
                case 15: result += "F"; break;
                default: result += remainder; break;
            }

        decNum /= 16;
        remainder = decNum % 16;

        }

        Console.Write("Hexadecimal representation of the number is: ");
        for (int i = result.Length; i > 0; i--)
        {
            Console.Write(result[i - 1]);
        }
        Console.WriteLine();
    }
}

