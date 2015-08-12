namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        public const int StudentIdMin = 10000;
        public static int StudentId = StudentIdMin;
        private ICollection<Course> courses;

        public School()
        {
            this.courses = new List<Course>();
        }

        public List<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        }

        public void AddCourse(Course newCourse)
        {
            if (newCourse == null)
            {
                throw new ArgumentNullException("Course is not initialized");
            }

            if (this.courses.Contains(newCourse))
            {
                throw new InvalidOperationException("This course already exists");
            }

            this.courses.Add(newCourse);
        }

        public void RemoveCourse(Course existingCourse)
        {
            if (!this.courses.Contains(existingCourse))
            {
                throw new InvalidOperationException("There is no such course");
            }

            this.courses.Remove(existingCourse);
        }
    }
}
