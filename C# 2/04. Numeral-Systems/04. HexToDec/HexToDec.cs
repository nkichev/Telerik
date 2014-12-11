//Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HexToDec
{
    static void Main()
    {
        Console.Write("Enter the hexadecimal number: ");
        string hexNum = Console.ReadLine();

        int result = 0;
        int len = hexNum.Length;

        for (int i = len - 1; i >= 0; i--)
        {
            switch (hexNum[i])
            {
                case 'A': result += 10 * (int)Math.Pow(16, len - 1 - i); break;
                case 'a': result += 10 * (int)Math.Pow(16, len - 1 - i); break;
                case 'B': result += 11 * (int)Math.Pow(16, len - 1 - i); break;
                case 'b': result += 11 * (int)Math.Pow(16, len - 1 - i); break;
                case 'C': result += 12 * (int)Math.Pow(16, len - 1 - i); break;
                case 'c': result += 12 * (int)Math.Pow(16, len - 1 - i); break;
                case 'D': result += 13 * (int)Math.Pow(16, len - 1 - i); break;
                case 'd': result += 13 * (int)Math.Pow(16, len - 1 - i); break;
                case 'E': result += 14 * (int)Math.Pow(16, len - 1 - i); break;
                case 'e': result += 14 * (int)Math.Pow(16, len - 1 - i); break;
                case 'F': result += 15 * (int)Math.Pow(16, len - 1 - i); break;
                case 'f': result += 15 * (int)Math.Pow(16, len - 1 - i); break;
                default: result += (hexNum[i] - '0') * (int)Math.Pow(16, len - 1 - i); break;
            }
        }
        Console.WriteLine("Decimal representation of the number is: {0}", result);
    }
}

