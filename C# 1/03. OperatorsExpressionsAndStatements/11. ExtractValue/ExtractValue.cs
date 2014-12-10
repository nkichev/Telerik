//Write an expression that extracts from a given integer i the value of a given bit number b.
//Example: i=5; b=2 => value=1.

using System;

class ExtractValue
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter a position: ");
        int b = int.Parse(Console.ReadLine());
        int mask = 1 << b;
        int result = i & mask;
        int bit = result >> b;
        Console.WriteLine("Bit on position {0} is: {1}", b, bit);
    }
}

