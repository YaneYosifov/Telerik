/* Problem 1. School classes
 * We are given a school. In the school there are classes of students. 
   Each class has a set of teachers. Each teacher teaches, 
   a set of disciplines. Students have a name and unique class number. 
   Classes have unique text identifier. Teachers have a name. 
   Disciplines have a name, number of lectures and number of exercises. 
   Both teachers and students are people. Students, classes, 
   teachers and disciplines could have optional comments (free text block).
 * Your task is to identify the classes (in terms of OOP) 
   and their attributes and operations, encapsulate their fields, 
   define the class hierarchy and create a class diagram with Visual Studio.
 */

namespace School
{
    using System;
    using System.Collections.Generic;

    class MainProgram
    {
        static void Main()
        {
            Class class12a = new Class("12a", LoadStudents(), LoadTeachers());

            for (int i = 0; i < class12a.Students.Count; i++)
            {
                Console.WriteLine("Student name: {0}", class12a.Students[i].Name);
                Console.WriteLine("Class number: {0}\n", class12a.Students[i].ClassNumber);
            }

            Console.WriteLine("\nTeacher name: {0}", class12a.Teachers[1].Name);
            Console.WriteLine("Disciplines:");
            Console.WriteLine("{0}", class12a.Teachers[1].Disciplines[2].Name);
            Console.WriteLine("{0}", class12a.Teachers[1].Disciplines[3].Name);
            Console.WriteLine();
        }

        private static List<Discipline> LoadDisciplines()
        {
            List<Discipline> disciplines = new List<Discipline>();

            disciplines.Add(new Discipline("algebra", 12, 12));
            disciplines.Add(new Discipline("trigonometry", 9, 12));
            disciplines.Add(new Discipline("biology", 12, 9));
            disciplines.Add(new Discipline("chemistry", 11, 11));
            disciplines.Add(new Discipline("art", 10, 10));

            return disciplines;
        }

        private static List<Student> LoadStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho Peshev", 15));
            students.Add(new Student("Stamat Stamatov", 19));
            students.Add(new Student("Georgi Georgiev", 11));

            return students;
        }

        private static List<Teacher> LoadTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher("Ivan Ivanov", LoadDisciplines()));
            teachers.Add(new Teacher("Stoyan Stoyanov", LoadDisciplines()));
            teachers.Add(new Teacher("Kiril Kirilov", LoadDisciplines()));

            return teachers;
        }
    }
}
