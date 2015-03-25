namespace Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        // Problem 9
        private static IOrderedEnumerable<Student> FromGroup2(List<Student> students)
        {
            var studentsGroup = from student in students
                                where student.GroupNumber == "2"
                                orderby student.FirstName
                                select student;
            return studentsGroup;
        }

        // Problem 11
        private static IEnumerable<Student> EmailAtAbvBg(List<Student> students)
        {
            var studentsEmail = from student in students
                                where student.Email.Substring(student.Email.IndexOf("@") + 1).Equals("abv.bg")
                                select student;
            return studentsEmail;
        }

        // Problem 12
        private static IEnumerable<Student> PhonesInSofia(List<Student> students)
        {
            var studentsPhones = from student in students
                                 where student.Tel.Substring(0, 2).Equals("02")
                                 select student;
            return studentsPhones;
        }

        // Problem 13
        private static IEnumerable<Student> Mark6(List<Student> students)
        {
            var mark = from student in students
                       where student.Marks.Contains(6)
                       select student;
            return mark;
        }

        // Problem 15
        private static IEnumerable<Student> EnrolledIn2006(List<Student> students)
        {
            var enrolled = from student in students
                           where student.FN.Substring(4, 2).Equals("06")
                           select student;
            return enrolled;
        }

        // Problem 18
        private static IEnumerable<Student> GroupNumber(List<Student> students)
        {
            var byGroupNumber = from student in students
                          orderby student.GroupNumber
                          select student;
            return byGroupNumber;
        }

        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student { FirstName = "Piers",    LastName = "Fraser",	  FN = "005009", Tel = "0889308111", Email = "piers.fraser@gmail.com",     GroupNumber = "1", Marks = new List<int> {2, 4} },
                new Student { FirstName = "Colin",    LastName = "MacDonald", FN = "065006", Tel = "0881986037", Email = "colin.macdonald@abv.bg",     GroupNumber = "4", Marks = new List<int> {3, 4, 6} },
                new Student { FirstName = "Ella",     LastName = "Hamilton",  FN = "070901", Tel = "0873016572", Email = "ella.hamilton@gmail.com",    GroupNumber = "2", Marks = new List<int> {6, 4, 3} },
                new Student { FirstName = "Lily",     LastName = "Ferguson",  FN = "261206", Tel = "021752042",  Email = "lily.ferguson@yahoo.com",    GroupNumber = "1", Marks = new List<int> {3, 5} },
                new Student { FirstName = "Andrea",   LastName = "Manning",	  FN = "281205", Tel = "0872898914", Email = "andrea.manning@abv.bg",      GroupNumber = "3", Marks = new List<int> {5, 6, 4, 3} },
                new Student { FirstName = "Lucas",    LastName = "Manning",	  FN = "390504", Tel = "0889260641", Email = "lucas.manning@gmail.com",    GroupNumber = "4", Marks = new List<int> {2, 2, 2, 5} },
                new Student { FirstName = "Emily",    LastName = "Wright",	  FN = "400806", Tel = "0843390118", Email = "emily.wright@gmail.com",     GroupNumber = "2", Marks = new List<int> {6, 3} },
                new Student { FirstName = "Dominic",  LastName = "Vance",	  FN = "401108", Tel = "024056164",  Email = "dominic.vance@abv.bg",       GroupNumber = "4", Marks = new List<int> {4, 4, 2} },
                new Student { FirstName = "Hannah",   LastName = "Mackay",	  FN = "440506", Tel = "028951731",  Email = "hannah.mackay@yahoo.com",    GroupNumber = "1", Marks = new List<int> {5, 5, 6} },
                new Student { FirstName = "Justin",   LastName = "Mackenzie", FN = "451108", Tel = "0881896218", Email = "justin.mackenzie@gmail.com", GroupNumber = "4", Marks = new List<int> {2, 2} },
                new Student { FirstName = "Jan",      LastName = "Vaughan",	  FN = "470701", Tel = "0864785866", Email = "jan.vaughan@gmail.com",      GroupNumber = "3", Marks = new List<int> {6, 6, 3} },
                new Student { FirstName = "Tim",      LastName = "Fraser",	  FN = "540906", Tel = "020534851",  Email = "tim.fraser@gmail.com",       GroupNumber = "2", Marks = new List<int> {2, 4, 4} },
                new Student { FirstName = "Joshua",   LastName = "MacLeod",   FN = "550800", Tel = "0885993618", Email = "joshua.macleod@abv.bg",      GroupNumber = "4", Marks = new List<int> {2, 3, 2, 3} },
                new Student { FirstName = "Yvonne",   LastName = "Watson",	  FN = "610608", Tel = "0874976492", Email = "yvonne.watson@gmail.com",    GroupNumber = "1", Marks = new List<int> {5, 4, 6} },
                new Student { FirstName = "Benjamin", LastName = "Hunter",	  FN = "651108", Tel = "0889195095", Email = "benjamin.hunter@yahoo.com",  GroupNumber = "4", Marks = new List<int> {4, 6, 3} },
                new Student { FirstName = "Jessica",  LastName = "Nolan",	  FN = "750401", Tel = "020440015",  Email = "jessica.nolan@gmail.com",    GroupNumber = "2", Marks = new List<int> {2, 2} },
                new Student { FirstName = "Isaac",    LastName = "Carr",	  FN = "801108", Tel = "0882164350", Email = "isaac.carr@abv.bg",          GroupNumber = "3", Marks = new List<int> {6, 2, 3} },
                new Student { FirstName = "Wendy",    LastName = "Newman",	  FN = "850306", Tel = "0884848875", Email = "wendy.newman@gmail.com",     GroupNumber = "1", Marks = new List<int> {2, 4, 4} },
                new Student { FirstName = "Zoe",      LastName = "Dowd",	  FN = "880409", Tel = "023296770",  Email = "zoe.dowd@gmail.com",         GroupNumber = "4", Marks = new List<int> {3, 5, 5, 6} },
                new Student { FirstName = "Kylie",    LastName = "Knox",	  FN = "990305", Tel = "0893815638", Email = "kylie.knox@yahoo.com",       GroupNumber = "2", Marks = new List<int> {5, 3, 2, 5} }
            };

            // Problem 9
            Console.WriteLine("{0}\nProblem 9\n{0}", new string('-', 70));
            Console.WriteLine("{0, -15} {1, -15} {2}", "First name", "Last name", "Group");
            Console.WriteLine(new string('-', 70));
            foreach (var student in FromGroup2(students))
            {
                Console.WriteLine("{0, -15} {1, -15} {2}", student.FirstName, student.LastName, student.GroupNumber);
            }
            Console.WriteLine();

            // Problem 10
            Console.WriteLine("{0}\nProblem 10\n{0}", new string('-', 70));
            Console.WriteLine("{0, -15} {1, -15} {2}", "First name", "Last name", "Group");
            Console.WriteLine(new string('-', 70));
            foreach (var student in students.StudentsFromGroup2Extension())
            {
                Console.WriteLine("{0, -15} {1, -15} {2}", student.FirstName, student.LastName, student.GroupNumber);
            }
            Console.WriteLine();

            // Problem 11
            Console.WriteLine("{0}\nProblem 11\n{0}", new string('-', 70));
            Console.WriteLine("{0, -15} {1, -15} {2}", "First name", "Last name", "Email");
            Console.WriteLine(new string('-', 70));
            foreach (var student in EmailAtAbvBg(students))
            {
                Console.WriteLine("{0, -15} {1, -15} {2}", student.FirstName, student.LastName, student.Email);
            }
            Console.WriteLine();

            // Problem 12
            Console.WriteLine("{0}\nProblem 12\n{0}", new string('-', 70));
            Console.WriteLine("{0, -15} {1, -15} {2}", "First name", "Last name", "Phone");
            Console.WriteLine(new string('-', 70));
            foreach (var student in PhonesInSofia(students))
            {
                Console.WriteLine("{0, -15} {1, -15} {2}", student.FirstName, student.LastName, student.Tel);
            }
            Console.WriteLine();

            // Problem 13
            Console.WriteLine("{0}\nProblem 13\n{0}", new string('-', 70));
            Console.WriteLine("{0, -15} {1, -15} {2}", "First name", "Last name", "Marks");
            Console.WriteLine(new string('-', 70));

            foreach (var student in Mark6(students))
            {
                Console.Write("{0, -15} {1, -15} ", student.FirstName, student.LastName);
                Console.WriteLine(string.Join(", ", student.Marks));
            }
            Console.WriteLine();

            // Problem 14
            Console.WriteLine("{0}\nProblem 14\n{0}", new string('-', 70));
            Console.WriteLine("{0, -15} {1, -15} {2}", "First name", "Last name", "Marks");
            Console.WriteLine(new string('-', 70));

            foreach (var student in students.StudentsWithTwo2Marks())
            {
                Console.Write("{0, -15} {1, -15} ", student.FirstName, student.LastName);
                Console.WriteLine(string.Join(", ", student.Marks));
            }
            Console.WriteLine();

            // Problem 15
            Console.WriteLine("{0}\nProblem 15\n{0}", new string('-', 70));
            Console.WriteLine("{0, -15} {1, -15} {2, -15} {3, -15}", "First name", "Last name", "Marks", "FN");
            Console.WriteLine(new string('-', 70));

            foreach (var student in EnrolledIn2006(students))
            {
                Console.Write("{0, -15} {1, -15} ", student.FirstName, student.LastName);
                Console.Write("{0, -15}", string.Join(", ", student.Marks));
                Console.WriteLine("{0, -15}", student.FN);
            }
            Console.WriteLine();

            // Problem 18
            Console.WriteLine("{0}\nProblem 18\n{0}", new string('-', 70));
            Console.WriteLine("{0, -15} {1, -15} {2}", "First name", "Last name", "Group number");
            Console.WriteLine(new string('-', 70));
            foreach (var student in GroupNumber(students))
            {
                Console.WriteLine("{0, -15} {1, -15} {2}", student.FirstName, student.LastName, student.GroupNumber);
            }
            Console.WriteLine();

            // Problem 19
            Console.WriteLine("{0}\nProblem 19\n{0}", new string('-', 70));
            Console.WriteLine("{0, -15} {1, -15} {2}", "First name", "Last name", "Group number");
            Console.WriteLine(new string('-', 70));
            foreach (var student in students.GroupNumberExtension())
            {
                Console.WriteLine("{0, -15} {1, -15} {2}", student.FirstName, student.LastName, student.GroupNumber);
            }
            Console.WriteLine();
        }
    }
}
