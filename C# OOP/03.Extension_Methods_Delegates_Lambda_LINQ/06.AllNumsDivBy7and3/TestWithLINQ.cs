using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.AllNumsDivBy7and3
{
    class TestWithLINQ
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            var result =
                from number in numbers
                where number % 21 == 0
                select number;

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
