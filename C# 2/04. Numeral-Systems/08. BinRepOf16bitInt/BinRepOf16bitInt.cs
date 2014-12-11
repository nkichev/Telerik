//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BinRepOf16bitInt
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(DecToBin(number));
        }
        static string DecToBin(short number)
        {
            char[] bit = new char[16];
            short pos = 15;
            short i = 0;

            while (i < 16)
            {
                if ((number & (1 << i)) != 0)
                {
                    bit[pos] = '1';
                }
                else
                {
                    bit[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(bit);
        }
    }
}
