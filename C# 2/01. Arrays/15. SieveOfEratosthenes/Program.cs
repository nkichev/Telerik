//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        const int max = 10000000;

        for (int i = 1; i <= max; i++)
        {
            numbers.Add(i); 
        }

        int counter = 2;
        int CurrentNumber = 2;

        while ((CurrentNumber * CurrentNumber) < max) 
        {
            while ((counter * CurrentNumber) <= max)
            {
                numbers[(counter * CurrentNumber) - 1] = 0; 
                counter++;
            }
            if (numbers[CurrentNumber] == 0) 
            {
                CurrentNumber += 2;
            }
            else
            {
                CurrentNumber++;
            }

            counter = 2;
        }

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] != 0)
            {
                Console.Write(numbers[i] + " "); 
            }
        }
 
    }
}

