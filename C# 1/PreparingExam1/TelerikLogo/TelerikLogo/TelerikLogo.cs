using System;

class TelerikLogo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int x = n;
        int z = x / 2 + 1;
        int length = 2 * z + 2 * x - 3;
        int outerdots = n / 2;
        int innerdots = 2 * x - 3;

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string('.', outerdots));
            Console.Write("*");
            Console.Write(new string('.', innerdots));
            Console.Write("*");
            Console.WriteLine(new string('.', outerdots));
            outerdots++;
            innerdots -= 2;
        }

        outerdots = length / 2;
        Console.Write(new string('.', outerdots));
        Console.Write("*");
        Console.WriteLine(new string('.', outerdots));

        outerdots--;
        innerdots = 1;

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string('.', outerdots));
            Console.Write("*");
            Console.Write(new string('.', innerdots));
            Console.Write("*");
            Console.WriteLine(new string('.', outerdots));
            innerdots += 2;
            outerdots--;
        }

        outerdots++;
        innerdots -= 2;

        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string('.', outerdots));
            Console.Write("*");
            Console.Write(new string('.', innerdots));
            Console.Write("*");
            Console.WriteLine(new string('.', outerdots));
            outerdots++;
            innerdots-=2;
        }
    }
}

