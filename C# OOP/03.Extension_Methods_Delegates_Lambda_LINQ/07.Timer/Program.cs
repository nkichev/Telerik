using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        public delegate void TimerDelegate();

        public class Timer
        {
            public static void RepeatMethod(TimerDelegate method, int seconds, long durationInSeconds)
            {
                long start = 0;
                while (start <= durationInSeconds)
                {
                    method();
                    Thread.Sleep(seconds * 1000);
                    start += seconds;
                }

            }

            public static void Print()
            {
                Console.WriteLine("Yeah it's funny!");
            }

            static void Main()
            {
                Timer.RepeatMethod(Print, 2, 10);
            }
        }
    }
}
