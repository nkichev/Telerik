using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideMethods
{
    class DivideMethods
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
        public static void DivideInt()
        {
            for (int i = 0; i >= 10000; )
            {
                i = i / 2;
            }
        }
        public static void DivideLong()
        {
            for (long i = 0; i >= 10000; )
            {
                i = i / 2;
            }
        }
        public static void DivideFloat()
        {
            for (float i = 0; i >= 10000; )
            {
                i = i / 2;
            }
        }
        public static void DivideDouble()
        {
            for (double i = 0; i >= 10000; )
            {
                i = i / 2;
            }
        }
        public static void DivideDecimal()
        {
            for (decimal i = 0; i >= 10000; )
            {
                i = i / 2;
            }
        }

        public static void Main()
        {
            DisplayPerformance(() => DivideInt(), "DivideInt");
            DisplayPerformance(() => DivideLong(), "DivideLong");
            DisplayPerformance(() => DivideFloat(), "DivideFloat");
            DisplayPerformance(() => DivideDouble(), "DivideDouble");
            DisplayPerformance(() => DivideDecimal(), "DivideDecimal");
        }
    }
}
