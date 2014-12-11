using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SqrtSinusLogMethods
{
    public class Test
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

        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            SqrtMethods.CalculateSqrtDouble(2d, 10000d, 0.002d);
            timer.Stop();
            Console.WriteLine("CalculateSqrtDouble" + " finished: " + timer.Elapsed.TotalMilliseconds + "ms");

            timer.Start();
            SqrtMethods.CalculateSqrtDecimal(2m, 10000m, 0.002m);
            timer.Stop();
            Console.WriteLine("CalculateSqrtDecimal" + " finished: " + timer.Elapsed.TotalMilliseconds + "ms");

            timer.Start();
            SqrtMethods.CalculateSqrtFloat(2f, 10000f, 0.002f);
            timer.Stop();
            Console.WriteLine("CalculateSqrtFloat" + " finished: " + timer.Elapsed.TotalMilliseconds + "ms");

            timer.Start();
            LogMethods.CalculateLogDouble(2d, 10000d, 0.002d);
            timer.Stop();
            Console.WriteLine("CalculateLogDouble" + " finished: " + timer.Elapsed.TotalMilliseconds + "ms");

            timer.Start();
            LogMethods.CalculateLogDecimal(2m, 10000m, 0.002m);
            timer.Stop();
            Console.WriteLine("CalculateLogDecimal" + " finished: " + timer.Elapsed.TotalMilliseconds + "ms");

            timer.Start();
            LogMethods.CalculateLogFloat(2f, 10000f, 0.002f);
            timer.Stop();
            Console.WriteLine("CalculateLogFloat" + " finished: " + timer.Elapsed.TotalMilliseconds + "ms");

            timer.Start();
            SinusMethods.CalculateSinDouble(2d, 10000d, 0.002d);
            timer.Stop();
            Console.WriteLine("CalculateSinDouble" + " finished: " + timer.Elapsed.TotalMilliseconds + "ms");

            timer.Start();
            SinusMethods.CalculateSinDecimal(2m, 10000m, 0.002m);
            timer.Stop();
            Console.WriteLine("CalculateSinDecimal" + " finished: " + timer.Elapsed.TotalMilliseconds + "ms");

            timer.Start();
            SinusMethods.CalculateSinFloat(2f, 10000f, 0.002f);
            timer.Stop();
            Console.WriteLine("CalculateSinFloat" + " finished: " + timer.Elapsed.TotalMilliseconds + "ms");
        }
    }
}
