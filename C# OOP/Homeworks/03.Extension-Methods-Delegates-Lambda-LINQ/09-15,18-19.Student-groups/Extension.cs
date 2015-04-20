/* Problem 10. Student groups extensions
 * Implement the previous using the same query expressed with extension methods.
 
 * Problem 14. Extract students with two marks
 * Write down a similar program that extracts the students with exactly two marks "2".
 * Use extension methods.
 * 
 * Problem 19. Grouped by GroupName extensions
 * Rewrite the previous using extension methods.
 */

namespace Student
{
    using System.Linq;
    using System.Collections.Generic;
    public static class Extension
    {
        // Problem 10
        public static IOrderedEnumerable<Student> StudentsFromGroup2Extension(this List<Student> students)
        {
            var studentsGroup = from student in students
                                where student.GroupNumber == "2"
                                orderby student.FirstName
                                select student;
            return studentsGroup;
        }

        // Problem 14
        public static IEnumerable<Student> StudentsWithTwo2Marks(this List<Student> students)
        {
            var studentsWithMarks = from student in students
                                    where student.Marks.Count == 2 && student.Marks[0].Equals(2) && student.Marks[1].Equals(2)
                                    select student;
            return studentsWithMarks;
        }

        // Problem 19
        public static IEnumerable<Student> GroupNumberExtension(this List<Student> students)
        {
            var byGroupNumber = from student in students
                          orderby student.GroupNumber
                          select student;
            return byGroupNumber;
        }
    }
}
