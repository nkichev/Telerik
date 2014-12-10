//Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01) false;  (5.00000001 ; 5.00000003) true

using System;

class SafelyCompare
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        float firstNum = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float secondNum = float.Parse(Console.ReadLine());
        
        float result = (float) (firstNum - secondNum);
        
        bool areEqual = result == 0;
        Console.WriteLine("Are equal: " + areEqual);
    }
}

