//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinToDec
{
    static void Main()
    {
        Console.Write("Enter the binary number: ");
        string binNum = Console.ReadLine();

        double result = 0;

        for (int i = 0; i < binNum.Length; i++)
        {
            if (binNum[i] != '0' && binNum[i] != '1')
            {
                Console.WriteLine("Wrong number!");
                return;
            }
            if (binNum[binNum.Length - 1 - i] == '1')
            {
                result += Math.Pow(2, i);
            }

        }
        Console.WriteLine("The number is: {0}", result);
    }
}

