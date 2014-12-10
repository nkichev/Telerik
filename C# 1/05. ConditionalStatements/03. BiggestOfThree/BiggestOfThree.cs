//Write a program that finds the biggest of three integers using nested if statements.

using System;

    class BiggestOfThree
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int thirdNum = int.Parse(Console.ReadLine());
            int maxNum = firstNum;
            if (secondNum > firstNum)
            {
                maxNum = secondNum;
            }
            if (thirdNum > secondNum)
            {
                maxNum = thirdNum;
            }
            Console.WriteLine("The biggest number is : {0}", maxNum);
        }
    }

