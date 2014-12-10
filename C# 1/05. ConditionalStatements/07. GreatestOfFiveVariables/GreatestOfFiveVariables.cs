//Write a program that finds the greatest of given 5 variables.

using System;

    class GreatestOfFiveVariables
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double thirdNum = double.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            double fourthNum = double.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            double fifthNum = double.Parse(Console.ReadLine());
            double maxNum = firstNum;

            if (secondNum > maxNum)
            {
                maxNum = secondNum;
            }
            if (thirdNum > maxNum)
	        {
	            maxNum = thirdNum;	 
	        }
            if (fourthNum > maxNum)
            {
                maxNum = fourthNum;
            }
            if (fifthNum > maxNum)
            {
                maxNum = fifthNum;
            }
            Console.WriteLine("The greatest number is : {0}", maxNum);
        }
    }

