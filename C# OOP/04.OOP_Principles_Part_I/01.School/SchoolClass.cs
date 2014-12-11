using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    public class SchoolClass : ICommentable
    {
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public string TextIdentifier { get; set; }
        public string Comment { get; set; }

        public SchoolClass(string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
        }
        public SchoolClass(string textIdentifier, List<Student> studentSet, List<Teacher> teacherSet)
        {
            this.TextIdentifier = textIdentifier;
            this.Students = studentSet;
            this.Teachers = teacherSet;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Class '{0}'",TextIdentifier));
            sb.AppendLine();
            sb.Append("\nSet of students:\n");
            foreach (var student in Students)
            {
                sb.Append(student + ";\n");
            }
            sb.Remove(sb.Length - 3, 3);
            sb.Append("\nSet of teachers:\n");
            foreach (var teacher in Teachers)
            {
                sb.Append(teacher + ";\n");
            }
            sb.Remove(sb.Length - 3, 3);
            return sb.ToString();
        }
    }
}
