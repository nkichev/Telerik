using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.StudentsNamesByAge
{
    class FindingNames
    {
        static void Main()
        {
            Student[] students = 
            {
                new Student { FirstName = "Petkan", LastName = "Sokolov", Age = 24 },
                new Student { FirstName = "Dobri", LastName = "Ivanov", Age = 18 },
                new Student { FirstName = "Pavel", LastName = "Dimitrov", Age = 22 },
                new Student { FirstName = "Milen", LastName = "Cvetkov", Age = 35 },
            };

            var namesOfStudents =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (var student in namesOfStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
