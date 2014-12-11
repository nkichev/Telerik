//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class GenerateRandomValuesBtw100and200
{
    static void Main()
    {
        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.Write("{0} ", rnd.Next(100, 201));
        }
    }
}
