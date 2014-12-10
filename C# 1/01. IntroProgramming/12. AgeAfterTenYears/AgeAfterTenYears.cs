using System;

    class AgeAfterTenYears
    {
        static void Main()
        {
            Console.WriteLine("Please enter your birth year:");
            int birthYear = int.Parse(Console.ReadLine());
            int now = DateTime.Now.Year;
            int age = (now - birthYear);
            Console.WriteLine("Your age after 10 years will be:");
            Console.WriteLine(age + 10);
        }
    }

