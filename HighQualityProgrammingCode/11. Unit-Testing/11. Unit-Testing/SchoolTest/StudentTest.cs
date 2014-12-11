using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using School;

namespace SchoolTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestConstructorStudentName()
        {
            Student newStudent = new Student("Todor", 10001);
            Assert.AreEqual("Todor", newStudent.Name);
        }

        [TestMethod]
        public void TestConstructorStudentUniqueNumber()
        {
            Student newStudent = new Student("Todor", 20020);
            Assert.AreEqual(20020, newStudent.UniqueNum);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorStudentNameEmpty()
        {
            Student newStudent = new Student("", 100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorStudentNameNull()
        {
            Student newStudent = new Student(null, 100);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestConstructorStudentUniqueNumberInBoundary()
        {
            Student newStudent = new Student("Pesho", 100);
        }
    }
}
