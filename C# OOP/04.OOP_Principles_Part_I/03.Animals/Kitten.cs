using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Sex.female)
        { }

        public override string ToString()
        {
            return string.Format("I'm the kitten {0}, {1} years old", Name, Age);
        }
        public override void Sound()
        {
            Console.WriteLine("I'm kitten and I'm sleeping.");
        }
    }
}
