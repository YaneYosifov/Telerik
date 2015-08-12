namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchollTests
    {
        [TestMethod]
        public void CreatingNewSchoolShoudNotThrowException()
        {
            var school = new School();
        }

        [TestMethod]
        public void AddingNewCourseToSchoolShoudNotThrowException()
        {
            var school = new School();
            school.AddCourse(new Course("High-Quality Code"));
        }

        [TestMethod]
        public void CourseShouldBeAddedToSchoolCorrectly()
        {
            var school = new School();
            var course = new Course("High-Quality Code");
            school.AddCourse(course);
            Assert.AreSame(course, school.Courses[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingDuplicatedCourseToSchoolShoudThrowException()
        {
            var school = new School();
            var course = new Course("High-Quality Code");
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNonInitializedCourseToSchoolShoudThrowException()
        {
            var school = new School();
            school.AddCourse(null);
        }

        [TestMethod]
        public void RemovingCourseThatIsAddedToSchoolShoudNotThrowException()
        {
            var school = new School();
            var course = new Course("High-Quality Code");
            school.AddCourse(course);
            school.RemoveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemovingCourseThatIsNotAddedToSchoolShoudThrowException()
        {
            var school = new School();
            school.RemoveCourse(new Course("High-Quality Code"));
        }
    }
}
