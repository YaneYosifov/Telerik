namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void StudentShouldReturnCorrectName()
        {
            var student = new Student("Marry");
            Assert.AreEqual("Marry", student.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingNewStudentWithEmptyNameShoudThrowException()
        {
            var student = new Student(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExceptionShouldBeThrownIfStudentIdIsGreaterThanMax()
        {
            for (int i = 0; i < Student.STUDENT_ID_MAX + 1; i++)
            {
                new Student("Marry" + i);
            }
        }
    }
}
