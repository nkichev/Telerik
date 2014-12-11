//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

using System;

class CalculateDaysBtw2Dates
{
    static void Main()
    {
        Console.Write("Enter the first date in format: day.month.year: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter the second date in format: day.month.year: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Days between the two dates are: {0}", (secondDate - firstDate).TotalDays);

    }
}

