using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace SchoolTest
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIfNotAllStudentsInSchoolHaveUniqueNumber()
        {
            List<Student> myColleaguesInJS = new List<Student>(){
            new Student("Pesho",20010),
            new Student("Gosho", 20000)
            };
            List<Student> myColleaguesInJava = new List<Student>(){
            new Student("Pesho",20011),
            new Student("Gosho", 20002)
            };
            List<Student> myColleaguesInOOP = new List<Student>(){
            new Student("Pesho",20003),
            new Student("Gosho", 20002)
            };
            Course myCourseJS = new Course("JS", myColleaguesInJS);
            Course myCourseJava = new Course("Java", myColleaguesInJava);
            Course myCourseOOP = new Course("OOP", myColleaguesInOOP);

            List<Course> myAllCourses = new List<Course>()
            {
               myCourseJS,
               myCourseJava,
               myCourseOOP
            };
            School.School mySchool = new School.School(myAllCourses);
        }

    }
}