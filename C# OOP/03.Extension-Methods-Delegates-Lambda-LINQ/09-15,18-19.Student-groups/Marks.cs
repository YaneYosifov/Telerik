/* Problem 13. Extract students by marks
 * Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
 */

namespace Student
{
    public class Mark
    {
        public int marks;
        public string fullName;

        public string FullName
        {
            get { return this.fullName; }
            set { this.fullName = value; }
        }

        public int Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }
        
    }
}
