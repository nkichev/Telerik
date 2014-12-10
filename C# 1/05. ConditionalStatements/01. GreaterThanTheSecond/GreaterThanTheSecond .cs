//Write an if statement that examines two integer variables and exchanges their values
//if the first one is greater than the second one.

using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter first value: ");
            int firstVal = int.Parse(Console.ReadLine());
            Console.Write("Enter second value: ");
            int secondVal = int.Parse(Console.ReadLine());
            int maxVal = firstVal;
            if (secondVal > firstVal)
            {
                maxVal = secondVal;
            }
            Console.WriteLine("{0} is the greater one.", maxVal);
        }
    }

