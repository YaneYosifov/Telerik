namespace ExceptionsHomework
{
    using System;

    public class SimpleMathExam : Exam
    {
        public SimpleMathExam(int problemsSolved)
        {
            if (problemsSolved < 0 || problemsSolved > 2)
            {
                throw new ArgumentOutOfRangeException("Solved problems must be in range 0-2");
            }

            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved { get; private set; }

        public override ExamResult Check()
        {
            if (this.ProblemsSolved == 0)
            {
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            }
            else if (this.ProblemsSolved == 1)
            {
                return new ExamResult(4, 2, 6, "Average result: half done.");
            }
            else if (this.ProblemsSolved == 2)
            {
                return new ExamResult(6, 2, 6, "Excelent result: all done.");
            }
            else
            {
                throw new ArgumentException("Invalid number of problems solved");
            }
        }
    }
}