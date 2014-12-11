using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Students
{
    class Sorting
    {
        static void Main()
        {
            Student[] students = 
            {
                new Student { FirstName = "Petkan", LastName = "Sokolov", Age = 24 },
                new Student { FirstName = "Dobri", LastName = "Ivanov", Age = 18 },
                new Student { FirstName = "Pavel", LastName = "Dimitrov", Age = 26 },
                new Student { FirstName = "Milen", LastName = "Cvetkov", Age = 35 },
            };

            var sortedStudents =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
