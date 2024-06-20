using System.Collections;
using System.Xml.Linq;
using static Homework_14._06._2024_Interfaces.Student;

namespace Homework_14._06._2024_Interfaces
{
    internal class Program
    {
        static void Main()
        {
            Student student = new();
            student.AddTestsRatings(12);
            student.AddCourseWorksRatings(12);
            student.AddExamsRatings(12);

            Student student1 = new("Evgeniya", "Sadova", new DateOnly(2001, 01, 01));
            student1.AddTestsRatings(11);
            student1.AddCourseWorksRatings(12);
            student1.AddExamsRatings(12);

            Student student2 = new("Irina", "Strat", new DateOnly(2002, 02, 02));
            student2.AddTestsRatings(10);
            student2.AddCourseWorksRatings(12);
            student2.AddExamsRatings(12);

            Student student3 = new("Liliya", "Khachatryan", new DateOnly(2003, 03, 03));
            student3.AddTestsRatings(9);
            student3.AddCourseWorksRatings(12);
            student3.AddExamsRatings(12);

            Student student4 = new("Artem", "Karp", new DateOnly(2004, 04, 04));
            student4.AddTestsRatings(8);
            student4.AddCourseWorksRatings(12);
            student4.AddExamsRatings(12);

            Student student5 = new("Alexandr", "Martinov", new DateOnly(2005, 05, 05));
            student5.AddTestsRatings(7);
            student5.AddCourseWorksRatings(12);
            student5.AddExamsRatings(12);

            Student student6 = new("Vitaly", "Ogorodnikov", new DateOnly(2006, 06, 06));
            student6.AddTestsRatings(2);
            student6.AddCourseWorksRatings(2);
            student6.AddExamsRatings(2);

            Student student7 = new("Maxim", "Fedorov-Marushchak", new DateOnly(1988, 10, 30));
            student7.AddTestsRatings(6);
            student7.AddCourseWorksRatings(12);
            student7.AddExamsRatings(12);

            List<Student> students = [];
            students.Add(student);
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);
            students.Add(student5);
            students.Add(student6);
            students.Add(student7);

            Console.WriteLine("Sorted by name from Student:\n");
            students.Sort(new SortByName().Compare);
            foreach (var st in students)
            {
                Console.WriteLine(st.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Sorted by last name from Student:\n");
            students.Sort(new SortByLastName().Compare);
            foreach (var st in students)
            {
                Console.WriteLine(st.LastName);
            }
            Console.WriteLine();

            Console.WriteLine("Sorted by date of birth from Student:\n");
            students.Sort(new SortByDateOfBirth().Compare);
            foreach (var st in students)
            {
                Console.WriteLine(st.DateOfBirth);
            }
            Console.WriteLine();

            Console.WriteLine("Sorted by average ratings from Student:\n");
            students.Sort(new SortByAvgRatings().Compare);
            foreach (var st in students)
            {
                Console.WriteLine(st.AverageRatings() + "\t" + st.Name);
            }
            Console.WriteLine();

            Group group = new();

            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);
            group.AddStudent(student5);
            group.AddStudent(student6);
            group.AddStudent(student7);
            group.AddStudent(student);

            Console.WriteLine(group);

            Console.WriteLine("Sorted by name in Group:\n");
            Group.Sort(students, new Student.SortByName());

            foreach (var stud in students)
            {
                Console.WriteLine(stud.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Sorted by Last Name in Group:\n");
            Group.Sort(students, new Student.SortByLastName());

            foreach (var stud in students)
            {
                Console.WriteLine(stud.LastName);
            }
            Console.WriteLine();

            Console.WriteLine("Sorted by Date Of Birth in Group:\n");
            Group.Sort(students, new Student.SortByDateOfBirth());

            foreach (var stud in students)
            {
                Console.WriteLine(stud.DateOfBirth + "   " + stud.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Sorted by Average Ratings in Group:\n");
            Group.Sort(students, new Student.SortByAvgRatings());

            foreach (var stud in students)
            {
                Console.WriteLine(stud.AverageRatings() + "\t" + stud.Name);
            }
            Console.WriteLine();

            Console.WriteLine("Search in Group by name:");

            group.SearchByName("Maxim");
            group.SearchByName("Vitaliy");
            group.SearchByName("Liliya");
            group.SearchByName("Irina");
            group.SearchByName("Evgeniya");
            group.SearchByName("Artem");
            group.SearchByName("Alexandr");
            group.SearchByName("Vasya");
            group.SearchByName("Petya");
            group.SearchByName("Marusya");

            Console.WriteLine("\nSearch in Group by lastname:");

            group.SearchByLastName("Fedorov-Marushchak");
            group.SearchByLastName("Ogorodnikov");
            group.SearchByLastName("Khachatryan");
            group.SearchByLastName("Strat");
            group.SearchByLastName("Sadova");
            group.SearchByLastName("Karp");
            group.SearchByLastName("Martinov");
            group.SearchByLastName("Pupkin");
            group.SearchByLastName("Bamper");
            group.SearchByLastName("Klimova");

            Console.WriteLine("\nSearch in Group by max average ratings:");
            group.SearchMaxRating();

            Console.WriteLine("\nSearch in Group by min average ratings:");
            group.SearchMinRating();
        }
    }

}
