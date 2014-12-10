//Write a program that applies bonus scores to given scores in the range [1..9].
//The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10;
//if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000.
//If it is zero or if the value is not a digit, the program must report an error.
//Use a switch statement and at the end print the calculated new value in the console.

using System;

    class ApplyBonusScores
    {
        static void Main()
        {
            Console.Write("Enter a digit : ");
            int digit = int.Parse(Console.ReadLine());

            switch (digit)
            {
                case 0: Console.WriteLine("Error!");
                    break;
                case 1: digit = digit * 10;
                    Console.WriteLine(digit);
                    break;
                case 2: digit = digit * 10;
                    Console.WriteLine(digit);
                    break;
                case 3: digit = digit * 10;
                    Console.WriteLine(digit);
                    break;
                case 4: digit = digit * 100;
                    Console.WriteLine(digit);
                    break;
                case 5: digit = digit * 100;
                    Console.WriteLine(digit);
                    break;
                case 6: digit = digit * 100;
                    Console.WriteLine(digit);
                    break;
                case 7: digit = digit * 1000;
                    Console.WriteLine(digit);
                    break;
                case 8: digit = digit * 1000;
                    Console.WriteLine(digit);
                    break;
                case 9: digit = digit * 1000;
                    Console.WriteLine(digit);
                    break;
                default: Console.WriteLine("Error!");
                    break;
            }
        }
    }

