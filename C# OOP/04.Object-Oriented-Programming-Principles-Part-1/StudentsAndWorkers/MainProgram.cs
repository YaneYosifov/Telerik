/* Problem 2. Students and workers

 * Define abstract class Human with a first name and a last name. 
   Define a new class Student which is derived from Human and has 
   a new field – grade. Define class Worker derived from Human 
   with a new property WeekSalary and WorkHoursPerDay and a method 
   MoneyPerHour() that returns money earned per hour by the worker. 
   Define the proper constructors and properties for this hierarchy.
 * Initialize a list of 10 students and sort them by grade 
   in ascending order (use LINQ or OrderBy() extension method).
 * Initialize a list of 10 workers and sort them 
   by money per hour in descending order.
 * Merge the lists and sort them by first name and last name.
 */

namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MainProgram
    {
        static void Main()
        {
            Console.WriteLine("{0, -20} {1}", "Students", "Grade");
            Console.WriteLine(new string('-', 40));
            List<Student> students = new List<Student>
            {
                new Student("Boris", "Stanimirov", 4),
                new Student("Krasimir", "Tsvetkov", 6),
                new Student("Ognian", "Eleonorov", 3),
                new Student("Marta", "Mirova", 1),
                new Student("Ivailo", "Mateev", 3),
                new Student("Anastasiya", "Donkova", 2),
                new Student("Sergey", "Krasimirov", 4),
                new Student("Anna", "Yordanova", 5),
                new Student("Mikhail", "Vladislavov", 5),
                new Student("Eva", "Rumenova", 2)
            };

            var orderedStudents = students.OrderBy(x => x.Grade);
            foreach (var student in orderedStudents)
            {
                string names = string.Format("{0} {1},", student.FirstName, student.LastName);
                Console.WriteLine("{0, -20} {1}", names, student.Grade);
            }
            Console.WriteLine();

            List<Worker> workers = new List<Worker>
            {
                new Worker("Micheal", "Dennis", 354, 5),
                new Worker("Rebecca", "Hudson", 1971, 7),
                new Worker("Victoria", "Owen", 327, 12),
                new Worker("Catherine", "Lindsey", 957, 10),
                new Worker("Myron", "Jones", 56, 8),
                new Worker("Lola", "Nichols", 76, 6),
                new Worker("Kristin", "Moran", 112, 9),
                new Worker("Al", "James", 840, 11),
                new Worker("Ricardo", "Fisher", 43, 8),
                new Worker("Caleb", "Potter", 5696, 4)
            };

            var orderedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            Console.WriteLine("{0, -20} {1}", "Workers", "Money per hour");
            Console.WriteLine(new string('-', 40));
            foreach (var worker in orderedWorkers)
            {
                string names = string.Format("{0} {1},", worker.FirstName, worker.LastName);
                Console.WriteLine("{0, -20} {1, 10:C}", names, worker.MoneyPerHour());
            }
            Console.WriteLine();

            var humans = students
                .Concat<Human>(workers)
                .OrderBy(x => x.FirstName)
                .ThenBy(y => y.LastName);
            Console.WriteLine("All persons");
            Console.WriteLine(new string('-', 40));
            foreach (var human in humans)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }
            Console.WriteLine();
        }
    }
}
