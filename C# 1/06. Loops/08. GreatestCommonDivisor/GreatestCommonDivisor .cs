//Write a program that calculates the greatest common divisor (GCD) of given two numbers.
//Use the Euclidean algorithm (find it in Internet).

using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number : ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter second number (second number < first number) : ");
            double secondNum = double.Parse(Console.ReadLine());

            double result;
            double remainder;

            Console.WriteLine();
            while (true)
            {
                result = firstNum / secondNum;
                remainder = firstNum % secondNum;
                if (remainder == 0)
                {
                    Console.WriteLine("The Greatest Common Divider is: {0}", secondNum);
                    break;
                    
                }
                else
                {
                    Console.WriteLine("{0} : {1} = {2} ; remainder = {3}", firstNum, secondNum, result, remainder);
                    firstNum = secondNum;
                    secondNum = remainder;
                }
            }
        }
    }

