//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangingBits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        for (int p1 = 3; p1 < 6; p1++) //bits of position 3, 4, 5
        {

            int p2 = p1 + 21;  //bits of position 24, 25, 26
            int mask1 = (1 << p1);
            int mask2 = (1 << p2);
            int bit1 = (n & mask1);
            int bit2 = (n & mask2);

            //bit of position p1 goes to bit of position p2
            if (bit1 == 0)
            {
                int replacer = (1 << p2);
                n = (n & ~replacer);
            }
            else
            {
                int replacer = (1 << p2);
                n = (n | replacer);
            }

            //bit of position p1 goes to bit of position p2
            if (bit2 == 0)
            {
                int replacer = (int)(1 << p1);
                n = (n & ~replacer);
            }
            else
            {
                int replacer = (int)(1 << p1);
                n = (n | replacer);
            }

        }
        Console.WriteLine(n);
    }
}

