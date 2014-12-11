//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;

class DecToBin
{
    static void Main()
    {
        Console.Write("Enter the decimal number: ");
        int decNum = int.Parse(Console.ReadLine());

        List<int> BinRep = new List<int>();

        while (decNum > 0)
        {
            BinRep.Add(decNum % 2);
            decNum = decNum / 2;
        }

        BinRep.Reverse();
        
        Console.Write("The binary representation of the number is: ");
        foreach (var item in BinRep)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}

