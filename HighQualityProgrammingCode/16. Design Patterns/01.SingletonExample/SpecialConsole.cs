namespace _01.SingletonExample
{
    using System;

    public sealed class SpecialConsole
    {
        private static readonly object padlock = new object();
        private static SpecialConsole instance = null;
        
        private SpecialConsole()
        {
        }

        public static SpecialConsole Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SpecialConsole();
                    }

                    return instance; 
                }
            }
        }

        public void WriteSomething(string msg)
        {
            Console.WriteLine("!!!" + msg + "!!!");
        }
    }
}