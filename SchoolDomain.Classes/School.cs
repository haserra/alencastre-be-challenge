using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolDomain.Classes
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int NumberOfCourses { get; set; }
        [Required]
        public ICollection<Course> Courses { get; set; }        
        public School()
        {
        }
        public School(string name, string address, int numberOfCourses)
        {
            Name = name;
            Address = address;
            NumberOfCourses = numberOfCourses;
            Courses = new List<Course>();
        }
    }
}
