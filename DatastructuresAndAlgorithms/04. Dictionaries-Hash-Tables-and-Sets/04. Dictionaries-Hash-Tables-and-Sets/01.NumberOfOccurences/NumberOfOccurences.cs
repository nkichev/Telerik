using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumberOfOccurences
{
    class NumberOfOccurences
    {
        //Write a program that counts in a given array of double values the number of occurrences of each value. Use Dictionary<TKey,TValue>.
        //Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
        //-2.5 => 2 times
        //3 => 4 times
        //4 => 3 times

        static void Main(string[] args)
        {
            double[] numbers = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            IDictionary<double, int> numbersCounts = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersCounts.ContainsKey(number))
                {
                    numbersCounts[number] = 1;
                }
                else
                {
                    numbersCounts[number]++;
                }
            }

            foreach (var kVPair in numbersCounts)
            {
                Console.WriteLine(kVPair.Key + " -> " + kVPair.Value);
            }
        }
    }
}
