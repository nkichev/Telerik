using System;

class Program
{
    static void Main()
    {
        double N = double.Parse(Console.ReadLine());
        double M = double.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());

        double mpProduct = M * P;
        double pProduct = 128.523123123 * P;
        int mod = ((int)M) % 180;
        double sinM = Math.Sin(mod);

        double result = (N * N + (1 / mpProduct) + 1337.0);
        result /= (N - pProduct);
        result += sinM;

        Console.WriteLine(result);

    }
}

