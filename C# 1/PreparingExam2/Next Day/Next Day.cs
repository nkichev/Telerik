using System;

class Program
{
    static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        DateTime today = new DateTime(year, month, day);
        DateTime tomorrow = new DateTime();
        tomorrow = today.AddDays(1);

        Console.WriteLine("{0:d.M.yyyy}", tomorrow);
    }
}

