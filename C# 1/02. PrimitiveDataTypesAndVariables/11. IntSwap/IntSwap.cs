//Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class IntSwap
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;
        c = a;
        a = b;
        b = c;
        Console.WriteLine("{0} {1}", a, b );
    }
}
