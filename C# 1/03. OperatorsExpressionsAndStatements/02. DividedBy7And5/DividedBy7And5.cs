//Write a boolean expression that checks for given integer if it can be divided (without remainder)
//by 7 and 5 in the same time.

using System;

class DividedBy7And5
{
    static void Main()
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine((number % 7 == 0) && (number % 5 == 0) ? "The number can be divided by 7 and 5" : "The number can not be divided by 7 and 5");
    }
}

