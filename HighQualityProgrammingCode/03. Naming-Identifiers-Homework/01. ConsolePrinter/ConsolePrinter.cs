namespace _01. ConsolePrinter
{
    using System;

    internal class ConsolePrinter
    {
        /// <summary>
        /// Represents how our cleaned code works
        /// </summary>
        public static void Main()
        {
            ConsolePrinter.NestedClass instance =
                new ConsolePrinter.NestedClass();

            instance.PrintValueToString(true);
        }

        /// <summary>
        /// Typical nested class
        /// </summary>
        private class NestedClass
        {
            /// <summary>
            /// Prints the input boolean value to the console
            /// </summary>
            /// <param name="value">inputted value</param>
            public void PrintValueToString(bool value)
            {
                string variableAsString = value.ToString();
                Console.WriteLine(variableAsString);
            }
        }
    }
}
