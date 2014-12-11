using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student
{
    public class Student : ICloneable, IComparable<Student>
    {
        //Properties
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public University UniversityName { get; set; }
        public Faculty FacultyName { get; set; }
        public Specialty SpecialtyName { get; set; }

        //Constructors
        public Student(string firstName, string middleName, string lastName, string ssn, string address,
            string mobilePhone, string email, int course, University university,
            Faculty faculty, Specialty specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.UniversityName = university;
            this.FacultyName = faculty;
            this.SpecialtyName = specialty;
        }
        public Student(string firstName, string middleName, string lastName, string ssn)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
        }

        //Methods
        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (student == null)
            {
                return false;
            }
            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }
            if (!Object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            return true;
        }

        public  static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }
        public static bool operator !=(Student first, Student second)
        {
            return !(Student.Equals(first, second));
        }
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} - {3}", FirstName, MiddleName, LastName, SSN);
        }
        public Student Clone()
        {
            Student original = this;
            Student result = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress,
                this.MobilePhone, this.Email, this.Course, this.UniversityName, this.FacultyName, this.SpecialtyName);

            return result;
        }
        Object ICloneable.Clone()
        {
            return this.Clone();
        }
        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return  (this.FirstName.CompareTo(student.FirstName));
            }
            if (this.MiddleName != student.MiddleName)
            {
                return  (this.MiddleName.CompareTo(student.MiddleName));
            }
            if (this.LastName != student.LastName)
            {
                return  (this.LastName.CompareTo(student.LastName));
            }
            if (this.SSN != student.SSN)
            {
                return  (this.SSN.CompareTo(student.SSN));
            }
            return 0;
        }
    }
}
