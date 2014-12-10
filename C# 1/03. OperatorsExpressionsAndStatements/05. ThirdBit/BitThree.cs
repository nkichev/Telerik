//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class BitThree
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int nAndmask = n & mask;
        int bit = nAndmask >> p;
        Console.WriteLine(bit);
    }
}

