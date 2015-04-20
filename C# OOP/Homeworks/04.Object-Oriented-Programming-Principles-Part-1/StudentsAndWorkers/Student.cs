namespace StudentsAndWorkers
{
    using System;
    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get { return grade; }
            set 
            {
                if (value < 1 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Grade must be in the interval [1...6]");
                }
                grade = value; 
            }
        }
        
    }
}
