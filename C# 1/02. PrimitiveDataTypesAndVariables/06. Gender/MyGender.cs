//Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

using System;

class MyGender
{
    static void Main()
    {
        bool isFemale;
        Console.Write("Enter your gender: ");
        string myGender = Console.ReadLine();

        if (myGender == "female")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }
        Console.WriteLine("Are you female: " + isFemale);
    }
}

