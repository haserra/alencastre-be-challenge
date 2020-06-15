
namespace SchoolDomain.Classes
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Area { get; set; }     
        public Subject(string name, string area)
        {
            Name = name;
            Area = area;
        }
    }
}
