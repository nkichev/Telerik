using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, Sex.male)
        { }

        public override string ToString()
        {
            return string.Format("I'm the tomcat {0}, {1} years old", Name, Age);
        }
        public override void Sound()
        {
            Console.WriteLine("I'm am tomcat and I'm sleeping.");
        }
    }
}
