using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensions
{
    class Test
    {
        static void Main()
        {
            List<double> list = new List<double> { 1.0, 2.0, 3.0, 4.0 };

            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Product());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Average());
        }
    }
}
