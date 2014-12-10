using System;

namespace DancingBits
{
    class Dance
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            string result = "";

            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());

                result += Convert.ToString(number, 2);
            }

            char previousChar = result[0];

            int count = 1;
            int endResult = 0;

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] == previousChar)
                {
                    count++;
                }
                else
                {
                    if (count == K)
                    {
                        endResult++;
                    }

                    count = 1;
                    previousChar = result[i];
                }
            }

            if (count == K)
            {
                endResult++;
            }

            Console.WriteLine(endResult);
        }
    }
}
