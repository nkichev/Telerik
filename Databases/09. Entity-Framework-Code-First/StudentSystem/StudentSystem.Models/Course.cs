using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Models
{
    public class Course
    {
        public Course()
        {
            this.CourseId = Guid.NewGuid();
            this.Students = new HashSet<Student>();
            this.Homeworks = new HashSet<Homework>();
        }

        public Guid CourseId { get; set; }

        [Column("CourseName")]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Homework> Homeworks { get; set; }
    }
}
