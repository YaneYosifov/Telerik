/* Problem 3. First before last
 * Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
 * Use LINQ query operators.

 * Problem 4. Age range
 * Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
 * 
 * Problem 5. Order students
 * Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order.
 * Rewrite the same with LINQ.
 */

namespace FirstBeforeLast
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    class FirstBeforeLast
    {
        private static IEnumerable<Student> specificNames(List<Student> humans)
        {
            IEnumerable<Student> result =
                from student in humans
                where student.FName.CompareTo(student.LName) < 0
                select student;
            return result;
        }

        private static IEnumerable<Student> Sort(List<Student> input)
        {
            var result = from value in input
                         orderby value.LName descending
                         orderby value.FName descending
                         select value;
            return result;
        }
        static void Main()
        {
            List<Student> students = new List<Student> 
            { 
                new Student { FName = "Pesho", LName = "Ivanov", Age = 20 },
                new Student { FName = "Georgi", LName = "Zlatev", Age = 19 },
                new Student { FName = "Mihail", LName = "Dimitrov", Age = 25 },
                new Student { FName = "Mihail", LName = "Stoyanov", Age = 30 },
                new Student { FName = "Maria", LName = "Stoimenova", Age = 23 }
            };

            Console.WriteLine("Filtered by names (first before last):");
            var result = specificNames(students);
            foreach (var student in result)
            {
                Console.WriteLine("{0} {1}", student.FName, student.LName);
            }

            Console.WriteLine("\nFiltered by age:");
            var specificAge = students.Where(st => st.Age >= 18 && st.Age <= 24);
            foreach (var student in specificAge)
            {
                Console.WriteLine("{0} {1}, {2}", student.FName, student.LName, student.Age);
            }

            Console.WriteLine("\nFiltered by names (descending order with lambda):");
            var namesDescending = students.OrderBy(st => st.FName).ThenBy(st => st.LName).Reverse();
            foreach (var student in namesDescending)
            {
                Console.WriteLine("{0} {1}", student.FName, student.LName);
            }

            Console.WriteLine("\nFiltered by names (descending order with LINQ):");
            var descendingSortwithLinq = Sort(students);
            foreach (var student in descendingSortwithLinq)
            {
                Console.WriteLine("{0} {1}", student.FName, student.LName);
            }
        }
    }
}
