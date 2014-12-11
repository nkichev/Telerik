using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ExtractElementsOccuringOddTimes
{
    class ExtractElementsOccuringOddTimes
    {
        //Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. Example:
        //{C#, SQL, PHP, PHP, SQL, SQL } => {C#, SQL}

        static void Main(string[] args)
        {
            string sequence = "C#, SQL, PHP, PHP, SQL, SQL";
            var strings = sequence.Split(new char[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            IDictionary<string, int> stringsCounts = new Dictionary<string, int>();

            foreach (var str in strings)
            {
                if (!stringsCounts.ContainsKey(str))
                {
                    stringsCounts[str] = 1;
                }
                else
                {
                    stringsCounts[str]++;
                }
            }

            foreach (var kVpair in stringsCounts)
            {
                if (kVpair.Value % 2 != 0)
                {
                    Console.WriteLine(kVpair.Key);
                }
            }
        }
    }
}
