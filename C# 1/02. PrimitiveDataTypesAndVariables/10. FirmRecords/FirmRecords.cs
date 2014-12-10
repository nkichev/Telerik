//A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

using System;

class FirmRecords
{
    static void Main()
    {
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter your family name: ");
        string familyName = Console.ReadLine();
        Console.Write("Enter your age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Enter your gender: ");
        char gender = Convert.ToChar (Console.ReadLine());
        Console.Write("Enter your ID number: ");
        uint idNum = uint.Parse(Console.ReadLine());
        Console.Write("Enter your Unique employee number ");
        int uniqueEmNum = int.Parse(Console.ReadLine());
        Console.WriteLine(firstName + " " + familyName + ", " + age + ", " + gender + ", " + idNum + ", " + uniqueEmNum);
    }
}

