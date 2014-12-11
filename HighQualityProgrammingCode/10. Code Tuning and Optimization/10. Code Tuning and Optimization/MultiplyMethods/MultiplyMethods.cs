using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyMethods
{
    class MultiplyMethods
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
        public static void MultiplyInt()
        {
            for (int i = 0; i <= 10000; )
            {
                i = i * 2;
            }
        }
        public static void MultiplyLong()
        {
            for (long i = 0; i <= 10000; )
            {
                i = i * 2;
            }
        }
        public static void MultiplyFloat()
        {
            for (float i = 0; i <= 10000; )
            {
                i = i * 2;
            }
        }
        public static void MultiplyDouble()
        {
            for (double i = 0; i <= 10000; )
            {
                i = i * 2;
            }
        }
        public static void MultiplyDecimal()
        {
            for (decimal i = 0; i <= 10000; )
            {
                i = i * 2;
            }
        }
        public static void Main()
        {
            DisplayPerformance(() => MultiplyInt(), "MultiplyInt");
            DisplayPerformance(() => MultiplyLong(), "MultiplyLong");
            DisplayPerformance(() => MultiplyFloat(), "MultiplyFloat");
            DisplayPerformance(() => MultiplyDouble(), "MultiplyDouble");
            DisplayPerformance(() => MultiplyDecimal(), "MultiplyDecimal");
        }
    }
}
