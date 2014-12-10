//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class NAndK2
{
    static void Main()
    {
        Console.Write("Enter N (N>1) : ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter K (K>N) : ");
        int K = int.Parse(Console.ReadLine());

        BigInteger productN = 1l;
        BigInteger productK = 1l;
        BigInteger difKN = K - N;
        BigInteger productKN = 1l;

        for (BigInteger i = difKN; i > 0; i--)
        {
            productKN *= i;
        }

        for (int i = N; i > 0; i--)
        {
            productN *= i;
        }

        for (int i = K; i > 0; i--)
        {
            productK *= i;
        }

        BigInteger product = (productN * productK) / productKN;

        Console.WriteLine("({0}! * {1}!) / ({1} - {0})! = {3}", N, K, productKN, product);
    }
}

