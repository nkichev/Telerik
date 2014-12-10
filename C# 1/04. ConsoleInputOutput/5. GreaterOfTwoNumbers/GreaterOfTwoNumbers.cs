//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class GreaterOfTwoNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        double max = Math.Max(firstNumber, secondNumber);
        Console.WriteLine(max);
    }
}

