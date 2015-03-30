namespace School
{
    using System;
    public class Student : Person, IComment
    {
        private int classNumber;
        public string Comment { get; private set; }

        public Student(string name, int classNumber) 
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Class number must be > 0");
                }
                this.classNumber = value;
            }
        }

        public void MakeComment(string text)
        {
            this.Comment = text;
        }
    }
}
