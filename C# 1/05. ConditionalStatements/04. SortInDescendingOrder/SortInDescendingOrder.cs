//Sort 3 real values in descending order using nested if statements.

using System;

    class SortInDescendingOrder
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double thirdNum = double.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                if (firstNum > thirdNum)
                {
                    if (secondNum > thirdNum)
                    {
                        Console.WriteLine("{0} {1} {2}", firstNum, secondNum, thirdNum);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2}", firstNum, thirdNum, secondNum);
                    }
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", thirdNum, firstNum, secondNum);
                }
            }
            else if (secondNum > thirdNum)
            {
                if (firstNum > thirdNum)
                {
                    Console.WriteLine("{0} {1} {2}", secondNum, firstNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", secondNum, thirdNum, firstNum);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", thirdNum, secondNum, firstNum);
            }
        }
    }

