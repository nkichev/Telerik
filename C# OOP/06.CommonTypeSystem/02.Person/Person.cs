using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Person
{
    public class Person
    {
        //Properties
        public string Name { get; set; }
        public int? Age { get; set; }

        //Constructors
        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Person(string name)
            : this(name, null)
        {
        }

        //Methods
        public override string ToString()
        {
            return string.Format("Name: {0}; Age: {1}.", Name, Age == null ? "Unknown" : Age.ToString());
        }
    }
}
