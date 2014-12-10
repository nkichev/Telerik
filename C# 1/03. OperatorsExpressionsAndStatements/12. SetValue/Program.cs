//We are given integer number n, value v (v=0 or 1) and a position p. 
//Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//Example: n = 5 (00000101), p=3, v=1 => 13 (00001101)
//n = 5 (00000101), p=2, v=0 => 1 (00000001)

using System;

class SetValue
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter a value (0;1): ");
        int v = int.Parse(Console.ReadLine());
        Console.Write("Enter a position: ");
        int p = int.Parse(Console.ReadLine());
        if (v == 0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine(result);
        }
        else
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine(result);
        }
    }
}

