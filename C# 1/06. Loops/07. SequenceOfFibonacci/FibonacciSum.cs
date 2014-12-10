//Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci:
//0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.

using System;

    class FibonacciSum
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            int N = int.Parse(Console.ReadLine());

            int firstNum = 1;
            int secondNum = 0;
            int result = 0;
            int sum = 0;

            for (int i = 1; i < N; i++)
            {
                result = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = result;
                sum += result;
            }
            Console.WriteLine("The sum = {0}", sum);
        }
    }

