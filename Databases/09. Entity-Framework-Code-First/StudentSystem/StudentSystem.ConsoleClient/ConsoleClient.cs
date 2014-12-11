using StudentSystem.Data;
using StudentSystem.Data.Migrations;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.ConsoleClient
{
    public class ConsoleClient
    {
        static void Main()
        {
            var data = new StudentSystemDbContext();

            var student = new Student 
            {
                FirstName = "Bat Ivan",
                LastName = "Ivanov"
            };

            data.Students.Add(student);
            data.SaveChanges();

            var students = data.Students;

            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " Level: " + item.Level);
            }
        }
    }
}
