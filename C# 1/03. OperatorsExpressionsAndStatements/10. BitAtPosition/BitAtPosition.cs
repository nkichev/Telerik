//Write a boolean expression that returns if the bit at position p (counting from 0)
//in a given integer number v has value of 1. Example: v=5; p=1 => false.

using System;

class BitAtPosition
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter a position: ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int vAndmask = v & mask;
        int bit = vAndmask >> p;
        bool result;
        if (bit == 1)
        {
            result = true;
        }
        else
        {
            result = false;
        }
        Console.WriteLine(result);
    }
}

