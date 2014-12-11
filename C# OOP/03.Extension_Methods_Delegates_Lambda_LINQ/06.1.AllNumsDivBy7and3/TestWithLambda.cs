using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.AllNumsDivBy7and3
{
    class TestWithLambda
    {
        static void Main()
        {
            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            var result = numbers.Where(number => number % 21 == 0);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
