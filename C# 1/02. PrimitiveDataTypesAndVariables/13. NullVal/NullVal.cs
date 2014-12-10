//Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

class NullVal
{
    static void Main()
    {
        int? intNumber = null;
        double? doubleNumber = null;
        Console.WriteLine("{0} {1}", intNumber, doubleNumber);
        intNumber = 5;
        Console.WriteLine(intNumber.GetValueOrDefault());
        doubleNumber = 4;
        Console.WriteLine(doubleNumber.GetValueOrDefault());
    }
}

