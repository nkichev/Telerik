namespace _01.SingletonExample
{
    using System;

    class Test
    {
        static void Main(string[] args)
        {
            var specConsole = SpecialConsole.Instance;

            specConsole.WriteSomething("cool");
        }
    }
}
