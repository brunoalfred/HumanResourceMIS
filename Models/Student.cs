
namespace HumanResourceMIS.Models
{
    public class Student
    {

        public int ID { set; get; }
        public string FirstName { set; get; } = string.Empty;

        public string Surname { set; get; } = string.Empty;

        public string Gender { set; get; } = string.Empty;

        public DateTime DateOfBirth { set; get; }

        public string Address { set; get; } = string.Empty;


        public ICollection<Enrollment> Enrollments { set; get; } = new List<Enrollment>();

    }

}