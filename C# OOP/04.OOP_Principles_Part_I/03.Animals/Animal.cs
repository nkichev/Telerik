using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    public abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Sex AnimalSex { get; set; }

        public Animal(string name, int age, Sex animalSex)
        {
            this.Name = name;
            this.Age = age;
            this.AnimalSex = animalSex;
        }

        public static double Average(Animal[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i].Age;
            }
            return sum / array.Length;
        }
    }
}
