using SchoolDomain.Classes;
using System.Data.Entity;

namespace SchoolDomain.DataModel
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
