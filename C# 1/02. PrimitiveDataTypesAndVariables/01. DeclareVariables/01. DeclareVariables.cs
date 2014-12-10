// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort firstVar = 52130;
        sbyte secondVar = -115;
        uint thirdVar = 4825932;
        byte fourtVar = 97;
        short fifthVar = -10000;
        Console.WriteLine("{0}, {1}, {2}, {3}, {4}", firstVar, secondVar, thirdVar, fourtVar, fifthVar);
    }
}
