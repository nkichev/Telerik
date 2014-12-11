//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

using System;

class ReadIntAndCalcSqrt
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        try
        {
            int number = int.Parse(Console.ReadLine());
            SquareRoot(number);
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid number.");
        }

        catch (OverflowException)
        {
            Console.WriteLine("The number is too big.");
        }

        finally
        {
            Console.WriteLine("Good Bye!");
        }
    }

    static void SquareRoot(double number)
    {
        if (number < 0)
        {
            throw new ArithmeticException("Invalid numer.");
        }

        double squareRoot = Math.Sqrt(number);
        Console.WriteLine("The square root of the number is: {0}", squareRoot);
    }
}

