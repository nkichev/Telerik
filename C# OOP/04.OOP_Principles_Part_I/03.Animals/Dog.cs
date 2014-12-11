using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Sex animalSex)
            : base(name, age, animalSex)
        { }

        public string Sound()
        {
            return "Bau!";
        }
        public override string ToString()
        {
            return string.Format("I'm the dog {0}, {1} years old, {2}", Name, Age, Sound());
        }
    }
}
