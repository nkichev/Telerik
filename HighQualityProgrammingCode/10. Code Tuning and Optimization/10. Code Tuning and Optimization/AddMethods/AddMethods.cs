using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace _02.ComparePerformance1
{
    public class AddMethods
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

        public static void AddInt()
        {
            for (int i = 0; i < 10000; )
            {
                i += 2;
            }
        }
        public static void AddLong()
        {
            for (long i = 0; i < 10000; )
            {
                i += 2;
            }
        }
        public static void AddFloat()
        {
            for (float i = 0; i < 10000; )
            {
                i += 2;
            }
        }
        public static void AddDouble()
        {
            for (double i = 0; i < 10000; )
            {
                i += 2;
            }
        }
        public static void AddDecimal()
        {
            for (decimal i = 0; i < 10000; )
            {
                i += 2;
            }
        }

        public static void Main()
        {
            DisplayPerformance(() => AddInt(), "AddInt");
            DisplayPerformance(() => AddLong(), "AddLong");
            DisplayPerformance(() => AddFloat(), "AddFloat");
            DisplayPerformance(() => AddDouble(), "AddDouble");
            DisplayPerformance(() => AddDecimal(), "AddDecimal");
        }
    }
}