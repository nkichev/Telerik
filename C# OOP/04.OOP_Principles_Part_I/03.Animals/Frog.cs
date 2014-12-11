using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, Sex animalSex)
            : base(name, age, animalSex)
        { }

        public void Sound()
        {
            Console.WriteLine("Croak!");
        }
        public override string ToString()
        {
            return string.Format("I'm the frog {0}, {1} years old", Name, Age);
        }
    }
}
