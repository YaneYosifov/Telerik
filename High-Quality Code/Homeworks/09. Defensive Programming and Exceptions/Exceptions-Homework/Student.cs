namespace ExceptionsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new FormatException("First name cannot be null or empty");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new FormatException("Last name cannot be null or empty");
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Exams = exams;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IList<Exam> Exams { get; set; }

        public IList<ExamResult> CheckExams()
        {
            this.AreExamsNullOrEmpty();

            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        public double CalcAverageExamResultInPercents()
        {
            this.AreExamsNullOrEmpty();

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }

        private void AreExamsNullOrEmpty()
        {
            if (this.Exams == null)
            {
                throw new Exception("Exams are not initialized");
            }

            if (this.Exams.Count == 0)
            {
                throw new Exception("Student has no exams");
            }
        }
    }
}