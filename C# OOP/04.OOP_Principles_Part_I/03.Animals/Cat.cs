using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, Sex animalSex)
            : base(name, age, animalSex)
        { 
        }

        public virtual void Sound()
        {
            Console.WriteLine("I'm cat and I'm sleeping.");
        }
        public override string ToString()
        {
            return string.Format("I am the cat {0}, {1} years old", Name, Age);
        }
    }
}
