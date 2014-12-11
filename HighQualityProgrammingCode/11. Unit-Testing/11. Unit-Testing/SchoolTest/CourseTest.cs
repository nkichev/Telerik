using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace SchoolTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void TestTheConstructorCourseName()
        {
            List<Student> myColleagues = new List<Student>(){
            new Student("Gosho",20010),
            new Student("Pesho", 20000)
            };
            Course myCourse = new Course("JS", myColleagues);
            Assert.AreEqual("JS", myCourse.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAllStudentsHaveUniqueNumber()
        {
            List<Student> myColleagues = new List<Student>(){
            new Student("Pesho",20010),
            new Student("Gosho", 20010)
            };
            Course myCourse = new Course("JS", myColleagues);
        }

        [TestMethod]
        public void TestAddStudent()
        {
            List<Student> myColleagues = new List<Student>(){
            new Student("Pesho",20011),
            new Student("Gosho", 20010)
            };

            Course myCourse = new Course("JS", myColleagues);
            Student newStudent = new Student("Mitko", 20012);

            myCourse.AddStudent(newStudent);
            int getLastStudentNumber = myCourse.StudentsInTheCourse.Count - 1;
            Assert.AreEqual("Mitko", myCourse.StudentsInTheCourse[getLastStudentNumber].Name);
        }

        [TestMethod]
        public void TestRemoveStudend()
        {
            Student testStudent = new Student("Ganio", 20012);
            List<Student> myColleagues = new List<Student>(){
            new Student("Pesho",20011),
            new Student("Gosho", 20010),
            };

            Course myCourse = new Course("JS", myColleagues);
            myCourse.AddStudent(testStudent);
            myCourse.RemoveStudent(testStudent);

            bool isThereThatStudent = false;
            foreach (var student in myCourse.StudentsInTheCourse)
            {
                if (student.UniqueNum == testStudent.UniqueNum)
                {
                    isThereThatStudent = true;
                }
            }

            Assert.AreEqual(false, isThereThatStudent);
            Assert.AreEqual(2, myCourse.StudentsInTheCourse.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemoveStudendIfThereNoSuchStudent()
        {
            Student testStudent = new Student("Ganio", 20012);
            List<Student> myColleagues = new List<Student>(){
            new Student("Pesho",20011),
            new Student("Gosho", 20010),
            };

            Course myCourse = new Course("JS", myColleagues);
            myCourse.RemoveStudent(testStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestReachLimitOfTheCourse()
        {
            List<Student> myColleagues = new List<Student>(){
            new Student("Pesho",20010),
            new Student("Gosho", 20000)
            };
            int uniqueNumber = 30000;
            Course myCourse = new Course("JS", myColleagues);
            for (int i = 0; i < 29; i++)
            {
                uniqueNumber++;
                Student newStudent = new Student("Marko", uniqueNumber);
                myCourse.AddStudent(newStudent);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorMoreStudentsSignUpThenMaximum()
        {
            List<Student> myColleagues = new List<Student>(){
            new Student("Pesho",20010),
            new Student("Gosho", 20000)
            };
            int uniqueNumber = 30000;
            for (int i = 0; i < 29; i++)
            {
                uniqueNumber++;
                Student newStudent = new Student("Marko", uniqueNumber);
                myColleagues.Add(newStudent);
            }
            Course myCourse = new Course("JS", myColleagues);
        }
    }
}