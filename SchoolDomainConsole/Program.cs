using SchoolDomain.Classes;
using SchoolDomain.DataModel;
using System;
using System.Data.Entity;
using System.Linq;

namespace SchoolDomainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to School Manager.");
            Console.WriteLine("\r\n\n");

            Database.SetInitializer(new NullDatabaseInitializer<SchoolDbContext>()); // Database initialization 

            InsertData();

            Console.WriteLine("Hit any key to continue.");
            Console.ReadKey();
        }
        private static void InsertData()
        {                       
            Console.WriteLine("1. Please insert the school name or hit enter for 'Share IT'.");
            Console.WriteLine("\r\n\n");
            string name = Console.ReadLine();
            if (name == "")
            {
                name = "Share IT";
            };
            Console.WriteLine($"School name:  {name}");
            Console.WriteLine("\r\n\n");

            Console.WriteLine("2. Please insert the school address or hit enter for 'Torres Vedras'.");
            Console.WriteLine("\r\n\n");
            string address = Console.ReadLine();            
            if (address == "")
            {
                address = "Torres Vedras";
            };
            Console.WriteLine($"School address:  {address}");
            Console.WriteLine("\r\n\n");

            Console.WriteLine($"3. Please insert how many courses {name} has or hit enter for two courses.");
            int numberCourses;
            try
            {
               numberCourses = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                numberCourses = 2;
            }
            Console.WriteLine($"Number of courses:  {numberCourses}");
            Console.WriteLine("\r\n\n");

            Console.WriteLine("4. Please insert the name of the course or hit enter for 'Eng. Informática'.");
            Console.WriteLine("\r\n\n");
            string courseName = Console.ReadLine();
            if (courseName == "")
            {
                courseName = "Eng. Informática";
            };
            Console.WriteLine($"Course name:  {courseName}");
            Console.WriteLine("\r\n\n");

            Console.WriteLine($"5. Please insert how many students the course {courseName} has or hit enter for 50 students.");            
            int numberStudents;
            try
            {
                numberStudents = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                numberStudents = 50;
            }
            Console.WriteLine($"Number of students:  {numberStudents}");
            Console.WriteLine("\r\n\n");

            Console.WriteLine("6. Please insert the name of the subject or hit enter for 'Matemática'.");
            Console.WriteLine("\r\n\n");
            string subjectName = Console.ReadLine();
            if (subjectName == "")
            {
                subjectName = "Matemática";
            };
            Console.WriteLine($"Subject name:  {subjectName}");
            Console.WriteLine("\r\n\n");


            Console.WriteLine("7. Please insert the subject area or hit enter for 'Ciências'.");
            Console.WriteLine("\r\n\n");
            string subjectArea = Console.ReadLine();
            if (subjectArea == "")
            {
                subjectArea = "Ciências";
            };
            Console.WriteLine($"Subject Area:  {subjectArea}");
            Console.WriteLine("\r\n\n");

            Console.WriteLine("8. Please insert the student name or hit enter for 'Joaquim'.");
            Console.WriteLine("\r\n\n");
            string studentName = Console.ReadLine();
            if (studentName == "")
            {
                studentName = "Joaquim";
            };
            Console.WriteLine($"Student name:  {studentName}");
            Console.WriteLine("\r\n\n");

            Console.WriteLine("9. Please insert the student address or hit enter for 'Alverca'.");
            Console.WriteLine("\r\n\n");
            string studentAddress = Console.ReadLine();
            if (studentAddress == "")
            {
                studentAddress = "Alverca";
            };
            Console.WriteLine($"Student Address:  {studentAddress}");
            Console.WriteLine("\r\n\n");

            Console.WriteLine($"10. Please insert how old is the student {studentName} or hit enter for 28.");
            Console.WriteLine("\r\n\n");
            int studentAge;
            try
            {
                studentAge = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                studentAge = 28;
            }
            Console.WriteLine($"Student Age:  {studentAge}");
            Console.WriteLine("\r\n\n");
            Console.WriteLine($"Now Press any key to insert data into the Data Base.");
            Console.ReadKey();

            InsertSchool(name,address,numberCourses);
            InsertCourse(courseName,numberStudents);
            InsertSubject(subjectName,subjectArea);
            InsertStudent(studentName,studentAddress,studentAge);
        }
       
        private static void InsertSchool(string name, string address, int numberCourses)
        {
            using (var context = new SchoolDbContext())
            {
                context.Database.Log = Console.WriteLine;
                var school = new School(name,address,numberCourses);
                context.Schools.Add(school);
                context.SaveChanges();
            }           
        }
        private static void InsertCourse(string courseName, int numberStudents)
        {
            using (var context = new SchoolDbContext())
            {
                context.Database.Log = Console.WriteLine;

                var schoolId = context.Schools.Where(n => n.Name == "Share IT").FirstOrDefault();

                var course = new Course(courseName,numberStudents,schoolId.Id);
                context.Courses.Add(course);
                context.SaveChanges();
            }
        }
        private static void InsertSubject(string subjectName, string subjectArea)
        {
            using (var context = new SchoolDbContext())
            {
                context.Database.Log = Console.WriteLine;
                var subject = new Subject(subjectName,subjectArea);
                context.Subjects.Add(subject);
                context.SaveChanges();
            }
        }
        private static void InsertStudent(string studentName, string studentAddress, int studentAge)
        {
            using (var context = new SchoolDbContext())
            {
                context.Database.Log = Console.WriteLine;

                var courseId = context.Courses.Where(c => c.Name == "Eng. Informática").FirstOrDefault();
                var student = new Student(studentName,studentAddress,studentAge,courseId.Id);
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }
}
