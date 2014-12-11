//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

using System;

class IfTheBracketsAreCorrect
{
    static void Main()
    {
        Console.Write("Enter expression: ");
        string str = Console.ReadLine();
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '(')
            {
                count++;
            }
            else if (str[i] == ')')
            {
                count--;
            }
            if (count < 0)
            {
                break;
            }
        }

        if (count == 0)
        {
            Console.WriteLine("The expression is correct.");
        }
        else
        {
            Console.WriteLine("The expression is not correct.");
        }
    }
}

