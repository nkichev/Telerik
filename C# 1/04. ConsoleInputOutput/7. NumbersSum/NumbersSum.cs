//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class NumbersSum
{
    static void Main()
    {
        Console.Write("Enter number of values: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int numbers;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number: ");
            numbers = int.Parse(Console.ReadLine());
            sum += numbers;
            Console.WriteLine("The sum is {0}", sum);
        }
    
    }
}

