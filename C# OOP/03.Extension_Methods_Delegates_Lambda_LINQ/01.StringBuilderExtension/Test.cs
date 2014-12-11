using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderExtension
{
    class Test
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Extension Methods, Delegates, Lambda, LINQ");

            Console.WriteLine(sb.Substring(10, 7)); 
            Console.WriteLine(sb.Substring(19, sb.Length - 19)); 
        }
    }
}
