namespace School
{
    using System;
    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;
        public string Comment { get; private set; }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public int NumberOfExercises
        {
            get { return this.numberOfExercises; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of exercises cannot be negative");
                }
                this.numberOfExercises = value; 
            }
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be negative");
                }
                this.numberOfLectures = value; 
            }
        }
        
        public string Name
        {
            get { return this.name; }
            set 
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Discipline name must be at least 2 symbols long");
                }
                this.name = value; 
            }
        }

        public void MakeComment(string text)
        {
            this.Comment = text;
        }
    }
}
