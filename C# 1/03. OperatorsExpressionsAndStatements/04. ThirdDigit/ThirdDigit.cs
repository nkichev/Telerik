//Write an expression that checks for given integer if its third digit (right-to-left) is 7.
//E. g. 1732 => true.

using System;

class ThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if ((number/100) % 10 == 7)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}

