namespace Combinatorics
{
    using System;
    using System.Numerics;

    public class BinaryPasswords
    {
        /* http://bgcoder.com/Contest/Practice/59 Task: 01. Двоични пароли. */

        public static void Main()
        {
            int count = 0;
            string line = Console.ReadLine();
            
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '*')
                {
                    count++;
                }
            }

            if (line.Length == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine((BigInteger)Math.Pow(2, count));
            }
        }
    }
}