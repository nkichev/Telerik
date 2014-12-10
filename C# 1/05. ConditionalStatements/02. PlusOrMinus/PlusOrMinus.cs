//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
//Use a sequence of if statements.

using System;

    class PlusOrMinus
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter first number: ");
            double secondNum = int.Parse(Console.ReadLine());
            Console.Write("Enter first number: ");
            double thirdNum = int.Parse(Console.ReadLine());
            int counter = 0;

            if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
            {
                Console.WriteLine("The product is : 0");
                return;
            }
            else
            {
                if (firstNum < 0)
                {
                    counter++;
                }
                if (secondNum < 0)
                {
                    counter++;
                }
                if (thirdNum < 0)
                {
                    counter++;
                }
                if (counter == 1 || counter == 2 || counter == 3)
                {
                    Console.WriteLine("The product is : -");
                }
                else
                {
                    Console.WriteLine("The product is : +");
                }
            }
        }
    }

