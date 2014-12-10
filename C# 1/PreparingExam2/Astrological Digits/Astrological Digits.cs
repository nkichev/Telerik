using System;

class Program
{
    static void Main()
    {
        string N = Console.ReadLine();

        int sum = 0;

        while (true)
        {
            for (int i = 0; i < N.Length; i++)
            {
                if (!(N[i] == '.' || N[i] == '-'))
                {
                    sum += int.Parse(N[i].ToString());
                }
            }
            if (sum < 10)
            {
                break;
            }
            N = sum.ToString();
            sum = 0;
        }
        Console.WriteLine(sum);
    }
}

