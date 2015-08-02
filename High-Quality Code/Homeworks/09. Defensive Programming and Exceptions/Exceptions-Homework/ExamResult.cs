namespace ExceptionsHomework
{
    using System;

    public class ExamResult
    {
        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            if (minGrade < 0)
            {
                throw new Exception("Minimum grade should be positive number");
            }

            if (maxGrade <= minGrade)
            {
                throw new Exception("Maximum grade should be greater than minimum grade");
            }

            if (grade < minGrade || grade > maxGrade)
            {
                throw new Exception("Grade must be in range between minimum grade and maximum grade");
            }

            if (string.IsNullOrEmpty(comments))
            {
                throw new Exception("Comments cannot be null or empty");
            }

            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade { get; private set; }

        public int MinGrade { get; private set; }

        public int MaxGrade { get; private set; }

        public string Comments { get; private set; }
    }
}