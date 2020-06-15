using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolDomain.Classes
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfStudents { get; set; }     
        public School School { get; set; } 
        public int SchoolId { get; set; } 
        [Required]
        public ICollection<Subject> Subjects { get; set; }
        public Course()
        {
        }
        public Course(string name, int numberOfStudents, int schoolId)
        {
            Name = name;
            NumberOfStudents = numberOfStudents;
            SchoolId = schoolId;
            Subjects = new List<Subject>();
        }
    }
}
