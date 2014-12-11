using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.StudentsSortingByFLNamesDescending
{
    class StudentsSorting
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

            var sortedStudents =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine();

            var sortedStudentss = students.OrderByDescending(student => student.FirstName).ThenBy(student => student.LastName);

            foreach (var student in sortedStudentss)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
