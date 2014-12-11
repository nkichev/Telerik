namespace _02.FactoryPatternExample
{
    using System;

    public class Cat : IChoice
    {
        public string Buy()
        {
            return "You bought a cat.";
        }
    }
}
