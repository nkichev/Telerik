//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and 
//prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
using System;
using System.Globalization;

class After6hs30minsAndDayOfWeek
{
    static void Main()
    {
        Console.Write("Enter date and time in the format: day.month.year hour:minute:second: ");
        string str = Console.ReadLine();

        DateTime date = DateTime.Parse(str);
        date = date.AddHours(6.5);

        Console.WriteLine("{0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
    }
}

