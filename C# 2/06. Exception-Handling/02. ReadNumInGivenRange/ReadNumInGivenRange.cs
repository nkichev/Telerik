//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:
//a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class ReadNumInGivenRange
{
    static void Main()
    {
        Console.Write("Enter start: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter end: ");
        int end = int.Parse(Console.ReadLine());
        ReadNumber(start, end);

    }

    static void ReadNumber(int start, int end)
    {
        int[] array = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter a number between {0} and {1}:", start, end);

            try
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < start)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (array[i] > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number.");
            }

            catch (OverflowException)
            {
                Console.WriteLine("The number is too big.");
            }

            if (i == array.Length - 1)
            {
                Numbers(array);
            }
        }

    }

    static void Numbers(int[] array)
    {
        Console.Write("Your numbers are: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]); 
        }
    }
}

