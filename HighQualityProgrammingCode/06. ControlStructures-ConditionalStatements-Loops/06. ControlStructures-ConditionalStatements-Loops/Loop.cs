namespace ControlStructuresConditionalStatementsLoops
{
    using System;
    using System.Linq;

    public class Loop
    {
        public void Main()
        {
            int expectedValue = 86;
            int length = 100;
            int[] arr = new int[length];
            
            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                if ((i % 10 == 0) && (currentElement == expectedValue))
                {
                    Console.WriteLine("Value found : {0}", currentElement);
                    break;
                }
                else
                {
                    Console.WriteLine(currentElement);
                }
            }
        }
    }
}
