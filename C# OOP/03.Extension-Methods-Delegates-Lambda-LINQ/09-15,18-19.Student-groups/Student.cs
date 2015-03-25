/* Problem 9. Student groups
 * Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
 */

namespace Student
{
    using System.Collections.Generic;
    public class Student
    {
        private string firstName;
        private string lastName;
        private string fn;
        private string tel;
        private string email;
        private List<int> marks;
        private string groupNumber;

        public string GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }
        
        public List<int> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }
        
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        
        public string Tel
        {
            get { return this.tel; }
            set { this.tel = value; }
        }
        
        public string FN
        {
            get { return this.fn; }
            set { this.fn = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        
    }
}
