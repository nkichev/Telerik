﻿//Write a program that, depending on the user's choice inputs int, double or string variable.
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
//The program must show the value of that variable as a console output. Use switch statement.

using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter 1 for int, 2 for double and 3 for string : ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: int intChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine(intChoice + 1);
                    break;
                case 2: double dChoice = double.Parse(Console.ReadLine());
                    Console.WriteLine(dChoice + 1);
                    break;
                case 3: string sChoice = Console.ReadLine();
                    Console.WriteLine(sChoice + "*");
                    break;
                default:Console.WriteLine("Error! ");
                    break;
            }
        }
    }

