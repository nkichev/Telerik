using System;

namespace Sheets
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int bitToTake;

            for (int i = 0; i < 11; i++)
			{
			    bitToTake = i;
                int mask = 1 << bitToTake;
                int numberAndMask = input & mask;
                int bashSiBit = numberAndMask >> bitToTake;

                if (bashSiBit == 0)
                {
                    Console.WriteLine("A" + (10 - i));
                }
			}
        }
    }
}
