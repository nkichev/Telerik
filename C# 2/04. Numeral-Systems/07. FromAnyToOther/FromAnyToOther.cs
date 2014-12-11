//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FromAnyToOther
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        string numberInput = Console.ReadLine();

        Console.Write("Enter the numeral system of your number: ");
        int NumSysFrom = int.Parse(Console.ReadLine());

        Console.Write("Enter the numeral system your number to be converted to: ");
        int NumSysTo = int.Parse(Console.ReadLine());
       
        char currentChar;
        int digit;
        int number = 0;

        for (int i = 0; i < numberInput.Length; i++)
        {
            currentChar = numberInput[i];
            if (currentChar >= 'a')
            {
                digit = currentChar - 'a' + 10;
            }
            else
            {
                digit = currentChar - '0';
            }
            number += (int)(digit * Math.Pow((double)NumSysFrom, (numberInput.Length - i - 1)));
        }

        string numberOutput = "";
        while (number != 0)
        {
            int remainder = number % NumSysTo;
            if (remainder <= 9)
            {
                numberOutput = remainder + numberOutput;
            }
            else
            {
                numberOutput = ((char)('A' + remainder - 10)) + numberOutput;
            }
            number /= NumSysTo;
        }
        Console.WriteLine("The result is {0}", numberOutput);
        
    }
}

