//Write a program to print the first 100 members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        BigInteger firstNumber = 0;
        BigInteger secondNumber = 1;
        Console.Write(firstNumber + ", " + secondNumber);
        for (int i = 1; i <= 100; i++)
        {
            BigInteger result = firstNumber + secondNumber; 
            Console.Write(", " + result);
            firstNumber = secondNumber;
            secondNumber = result;
        }
        Console.WriteLine();
    }
}

