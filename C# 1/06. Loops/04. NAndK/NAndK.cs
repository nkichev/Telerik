//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class NAndK
{
    static void Main()
    {
        Console.Write("Enter N (N>1) : ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter K (K<N) : ");
        int K = int.Parse(Console.ReadLine());

        long productN = 1l;
        long productK = 1l;

        for (int i = N; i > 0; i--)
        {
            productN *= i;
        }
           
        for (int i = K; i > 0; i--)
        { 
            productK *= i; 
        }
        Console.WriteLine("{0}! / {1}! = {2}", N, K, productN / productK);
    }
}

