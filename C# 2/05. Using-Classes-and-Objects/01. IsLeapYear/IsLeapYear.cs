//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class IsLeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine(DateTime.IsLeapYear(year) ? "The year is leap" : "The year is not leap");
    }
}
