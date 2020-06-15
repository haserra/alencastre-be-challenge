
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolDomain.Classes
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        [Required]
        public Course Course { get; set; } 
        public int CourseId { get; set; } 
        public ICollection<Subject> SubjectsEnrolled { get; set; }
        public Student(string name, string address, int age, int courseId)
        {
            Name = name;
            Address = address;
            Age = age;
            CourseId = courseId;
            SubjectsEnrolled = new List<Subject>();
            Course = new Course();
        }
    }
}
