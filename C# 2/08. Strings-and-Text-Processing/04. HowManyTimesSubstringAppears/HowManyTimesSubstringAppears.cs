//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//Example: The target substring is "in". The text is as follows:

//"We are living in an yellow submarine. We don't have anything else. 
//Inside the submarine is very tight. So we are drinking all the day. 
//We will move out of it in 5 days."

//The result is: 9.

using System;

class HowManyTimesSubstringAppears
{
    static void Main()
    {
        Console.Write("Enter some text: ");
        string text = Console.ReadLine();
        Console.Write("Enter the substring we are looking for: ");
        string substr = Console.ReadLine();

        int index = text.IndexOf(substr, StringComparison.CurrentCultureIgnoreCase);
        int count = 0;

        while (index != -1)
        {
            count++;
            index = text.IndexOf(substr, index + 1);
        }

        Console.WriteLine("The substring \"{0}\" appears: {1} times", substr, count);
    }
}

