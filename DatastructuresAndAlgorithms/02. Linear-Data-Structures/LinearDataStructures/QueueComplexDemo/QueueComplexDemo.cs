﻿namespace QueueComplexDemo
{
    using System;
    using System.Collections.Generic;

    public class QueueComplexDemo
    {
        /* 10.  We are given numbers N and M and the following operations:
        N = N+1
        N = N+2
        N = N*2
        Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M. Hint: use a queue.
        Example: N = 5, M = 16
        Sequence: 5 -> 7 -> 8 -> 16
        */

        public static void Main()
        {
            Console.WriteLine("Pleasse enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Pleasse enter m: ");
            int m = int.Parse(Console.ReadLine());

            if (m < n)
            {
                throw new ArgumentOutOfRangeException("m must not be greater than n!");
            }

            Queue<int> sequence = new Queue<int>();
            List<int> shortestWay = new List<int>();
            sequence.Enqueue(n);
            int current = n;

            while (true)
            {
                current = sequence.Dequeue();
                if (current > m)
                {
                    continue;
                }
                if (current == m)
                {
                    shortestWay.Add(current);
                    break;
                }
                else
                {
                    shortestWay.Add(current);
                    sequence.Enqueue(current * 2);
                    sequence.Enqueue(current + 2);
                    sequence.Enqueue(current + 1);
                }
            }

            Console.WriteLine("Shortest path: " + string.Join(", ", shortestWay));
        }
    }
}