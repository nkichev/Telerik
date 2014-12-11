using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Frog[] frogs =
            {
                new Frog( "Frog1", 4, Sex.male),
                new Frog( "Frog2", 5, Sex.female),
                new Frog( "Frog3", 15, Sex.male),
                new Frog( "Frog4", 9, Sex.male)
            };

            Dog[] dogs =
            {
                new Dog( "Dog1", 8, Sex.male),
                new Dog( "Dog2", 7, Sex.female),
                new Dog( "Dog3", 4, Sex.male),
                new Dog( "Dog4", 1, Sex.female)
            };

            Cat[] cats =
            {
                new Kitten( "Cat1", 3),
                new Tomcat( "Cat2", 5),
                new Kitten( "Cat3", 9),
                new Tomcat( "Cat4", 10)
            };

            foreach (var item in frogs)
            {
                item.Sound();
            }

            foreach (var item in cats)
            {
                item.Sound();
            }
            
            Console.WriteLine("Average age of dogs " + Animal.Average(dogs));
            Console.WriteLine("Average age of frogs " + Animal.Average(frogs));
            Console.WriteLine("Average age of cats " + Animal.Average(cats));

        }
    }
}
