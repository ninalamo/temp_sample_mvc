using WebApplication2.Data.SeedWork;

namespace WebApplication2.Data
{
    public class Student : Entity
    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public string? MiddleName { get; private set; }
        public Student()
        {
            
        }
        public Student(string? firstName, string? lastName, string? middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
    }
}
