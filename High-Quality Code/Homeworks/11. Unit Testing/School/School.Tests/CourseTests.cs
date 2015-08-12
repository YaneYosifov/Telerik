namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void CreatingNewCourseShoudNotThrowException()
        {
            var course = new Course("JavaScript Applications");
        }

        [TestMethod]
        public void CourseShouldReturnCorrectName()
        {
            var course = new Course("JavaScript Applications");
            Assert.AreEqual("JavaScript Applications", course.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingNewCourseWithEmptyNameShoudThrowException()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreatingNewCourseWithNonInitializedNameShoudThrowException()
        {
            var course = new Course(null);
        }

        [TestMethod]
        public void AddingNewStudentToCourseShoudNotThrowException()
        {
            var course = new Course("JavaScript Applications");
            course.AddStudent(new Student("Smith"));
        }

        [TestMethod]
        public void StudentShouldBeAddedToCourseCorrectly()
        {
            var course = new Course("JavaScript Applications");
            var student = new Student("Smith");
            course.AddStudent(student);
            Assert.AreSame(student, course.Students[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingDuplicatedStudentToCourseShoudThrowException()
        {
            var course = new Course("JavaScript Applications");
            var student = new Student("Smith");
            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNonInitializedStudentToCourseShoudThrowException()
        {
            var course = new Course("JavaScript Applications");
            course.AddStudent(null);
        }

        [TestMethod]
        public void AddingMaxStudentsToCourseShoudNotThrowException()
        {
            var course = new Course("JavaScript Applications");
            for (int i = 0; i < Course.MAX_STUDENTS; i++)
            {
                course.AddStudent(new Student("Smith" + i));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddingMoreThanMaxStudentsToCourseShoudThrowException()
        {
            var course = new Course("JavaScript Applications");
            for (int i = 0; i < Course.MAX_STUDENTS + 1; i++)
            {
                course.AddStudent(new Student("Smith" + i));
            }
        }

        [TestMethod]
        public void RemovingStudentThatIsAddedToCourseShoudNotThrowException()
        {
            var course = new Course("JavaScript Applications");
            var student = new Student("Smith");
            course.AddStudent(student);
            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemovingStudentThatIsNotAddedToCourseShoudThrowException()
        {
            var course = new Course("JavaScript Applications");
            course.RemoveStudent(new Student("Smith"));
        }
    }
}
