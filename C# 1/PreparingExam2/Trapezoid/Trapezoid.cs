using System;

class Trapezoid
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int outerdots = N - 1;
        int innerdots = N - 1;

        Console.Write(new string('.', N));
        Console.Write(new string('*', N));
        Console.WriteLine();

        for (int i = 0; i < N - 1; i++)
        {
            Console.Write(new string('.', outerdots));
            Console.Write("*");
            Console.Write(new string('.', innerdots));
            Console.Write("*");
            Console.WriteLine();
            outerdots--;
            innerdots++;
        }
        Console.WriteLine(new string('*', N * 2));
    }
}
