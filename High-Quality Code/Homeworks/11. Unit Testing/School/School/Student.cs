namespace School
{
    using System;
    using System.Threading;

    public class Student
    {
        public const int StudentIdMax = 99999;
        private int id;
        private string name;

        public Student(string name)
        {
            this.Name = name;
            int nextId = Interlocked.Increment(ref School.StudentId);
            if (nextId > StudentIdMax)
            {
                throw new ArgumentOutOfRangeException("Student ID cannot be greater than 99999");
            }

            this.id = nextId;
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
                    throw new ArgumentNullException("Student name cannot be empty");
                }

                this.name = value; 
            }
        }

        public int Id
        {
            get { return this.id; }
        }
    }
}
