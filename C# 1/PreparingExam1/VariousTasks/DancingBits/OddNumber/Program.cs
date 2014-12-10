using System;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            long result = long.Parse(Console.ReadLine());

            for (int i = 1; i < N; i++)
            {
                result ^= long.Parse(Console.ReadLine());
            }

            Console.WriteLine(result);
        }
    }
}
