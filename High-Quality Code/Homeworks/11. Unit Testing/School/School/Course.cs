namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Course
    {
        public const int MaxStudents = 30;
        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }

            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course name cannot be empty");
                }

                this.name = value; 
            }
        }

        public List<Student> Students
        {
            get 
            { 
                return new List<Student>(this.students); 
            }
        }

        public void AddStudent(Student newStudent)
        {
            if (newStudent == null)
            {
                throw new ArgumentNullException("Student is not initialized");
            }

            if (this.students.Count >= MaxStudents)
            {
                throw new ArgumentOutOfRangeException("Students in a course cannot be more than 30");
            }

            if (this.students.Any(st => st.Id == newStudent.Id))
            {
                throw new InvalidOperationException("Student with the same ID already exists");
            }

            this.students.Add(newStudent);
        }

        public void RemoveStudent(Student existingStudent)
        {
            if (!this.students.Contains(existingStudent))
            {
                throw new InvalidOperationException("There is no such student");
            }

            this.students.Remove(existingStudent);
        }
    }
}
