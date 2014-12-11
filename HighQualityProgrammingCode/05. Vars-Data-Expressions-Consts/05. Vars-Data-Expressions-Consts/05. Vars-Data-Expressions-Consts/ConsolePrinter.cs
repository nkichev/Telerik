namespace _05.Vars_Data_Expressions_Consts
{
    using System;
    using System.Linq;

    internal class ConsolePrinter
    {
        public void PrintStatistics(double[] arr)
        {
            double maxElement = double.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                double currentElement = arr[i];
                if (currentElement > maxElement)
                {
                    maxElement = currentElement;
                }
            }
            Console.WriteLine("Max element is : {0}", maxElement);

            double minElement = double.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                double currentElement = arr[i];
                if (currentElement < minElement)
                {
                    minElement = currentElement;
                }
            }
            Console.WriteLine("Min element is : {0}", minElement);

            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                double currentElement = arr[i];
                sum += currentElement;
            }

            double average = sum / arr.Length;
            Console.WriteLine("The average is : {0}", average);
        }
    }
}
