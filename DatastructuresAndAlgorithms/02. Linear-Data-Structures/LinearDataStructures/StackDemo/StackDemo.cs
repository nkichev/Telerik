namespace StackDemo
{
    using System;
    using System.Collections.Generic;

    public class StackDemo
    {
        /* 02. Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class. */
        
        public static void Main()
        {
            Console.WriteLine("Please, enter N:");
            string line = Console.ReadLine();
            uint n = uint.Parse(line);
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please, enter {0} number:", i + 1);
                int currentNumber = int.Parse(Console.ReadLine());
                numbers.Push(currentNumber);
            }

            Console.WriteLine("Reversed Numbers:");
            PrintStack(numbers);
        }

        private static void PrintStack(Stack<int> numbers)
        { 
            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}