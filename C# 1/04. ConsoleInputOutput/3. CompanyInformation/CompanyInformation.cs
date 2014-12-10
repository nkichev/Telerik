//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyInformation
{
    static void Main()
    {
        //Comapany information
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        int companyNumber = int.Parse(Console.ReadLine());
        Console.Write("Fax number: ");
        int companyFax = int.Parse(Console.ReadLine());
        Console.Write("Web site: ");
        string companySite = Console.ReadLine();
        
        //Manager information
        Console.Write("Enter manager first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Phone number: ");
        int phoneNumber = int.Parse(Console.ReadLine());
       
        Console.WriteLine("The company {0}, is located on {1}, phone number - {2}, fax number - {3}, web site - {4}.", companyName, companyAddress, companyNumber, companyFax, companySite);
        Console.WriteLine("The manager of the company is {0} {1}, {2} years old, phone number - {3}.", firstName, lastName, age, phoneNumber);
    }
}

