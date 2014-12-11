namespace _02.FactoryPatternExample
{
    using System;

    public class Dog : IChoice
    {
        public string Buy()
        {
            return "You bought a dog.";
        }
    }
}
