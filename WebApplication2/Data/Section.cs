using WebApplication2.Data.SeedWork;

namespace WebApplication2.Data
{
    public class Section : Entity
    {
        public string? Name { get; private set; }
        public List<Student> Students { get; private set; }

        public Section()
        {
            
        }
        public Section(string? name, List<Student> students)
        {
            Name = name;
            Students = students;
        }
    }
}
