namespace _02.FactoryPatternExample
{
    using System;

    public class ChoiceFactory
    {
        public static IChoice GetChoiceObj(string choice)
        {
            IChoice obj = null;

            if (choice.ToLower() == "cat")
            {
                obj = new Cat();   
            }
            else if (choice.ToLower() == "dog")
            {
                obj = new Dog();
            }

            return obj;
        }
    }
}
