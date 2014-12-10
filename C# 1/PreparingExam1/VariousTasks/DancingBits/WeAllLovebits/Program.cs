using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAllLovebits
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int number = int.Parse(Console.ReadLine());

                string normalNumberAsString = Convert.ToString(number, 2);
                string reversedNumberAsstring = "";

                for (int j = normalNumberAsString.Length - 1; j >= 0; j--)
                {
                    reversedNumberAsstring += normalNumberAsString[j];
                }

                int endResult = Convert.ToInt32(reversedNumberAsstring, 2);

                Console.WriteLine(endResult);
            }
        }
    }
}
