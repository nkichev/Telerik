namespace _03.FacadePatternExample
{
    using System;

    class MainApp
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            Console.WriteLine("Morning time:");
            Console.WriteLine(new string('-', 55));
            facade.MorningTasks();

            Console.WriteLine();

            Console.WriteLine("Evening time:");
            Console.WriteLine(new string('-', 55));
            facade.EveningTasks();
        }
    }
}
