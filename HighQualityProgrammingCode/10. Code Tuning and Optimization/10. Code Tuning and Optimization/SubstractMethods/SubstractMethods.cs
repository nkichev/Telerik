using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ComparePerformance1
{
    public class SubstractMethods
    {
        public static void DisplayPerformance(Action method, string methodName)
        {
            Console.WriteLine(methodName + " starting: ");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            method();
            timer.Stop();
            Console.WriteLine(methodName + " finished: " + timer.Elapsed.TotalMilliseconds + "ms");
        }

        public static void SubstractInt()
        {
            for (int i = 0; i > 10000; )
            {
                i -= 2;
            }
        }
        public static void SubstractLong()
        {
            for (long i = 0; i > 10000; )
            {
                i -= 2;
            }
        }
        public static void SubstractFloat()
        {
            for (float i = 0; i > 10000; )
            {
                i -= 2;
            }
        }
        public static void SubstractDouble()
        {
            for (double i = 0; i > 10000; )
            {
                i -= 2;
            }
        }
        public static void SubstractDecimal()
        {
            for (decimal i = 0; i > 10000; )
            {
                i -= 2;
            }
        }

        public static void Main()
        {
            DisplayPerformance(() => SubstractInt(), "SubstractInt");
            DisplayPerformance(() => SubstractLong(), "SubstractLong");
            DisplayPerformance(() => SubstractFloat(), "SubstractFloat");
            DisplayPerformance(() => SubstractDouble(), "SubstractDouble");
            DisplayPerformance(() => SubstractDecimal(), "SubstractDecimal");
        }
    }
}
