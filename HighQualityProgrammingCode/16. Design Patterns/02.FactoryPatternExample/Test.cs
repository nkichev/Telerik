namespace _02.FactoryPatternExample
{
    using System;

    class Test
    {
        static void Main(string[] args)
        {
            IChoice dog = ChoiceFactory.GetChoiceObj("dog");
            Console.WriteLine(dog.Buy());

            IChoice cat = ChoiceFactory.GetChoiceObj("cat");
            Console.WriteLine(cat.Buy());
        }
    }
}
