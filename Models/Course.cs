using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResourceMIS.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { set; get; }
        public string Title { set; get; } = string.Empty;
        public string Code { set; get; } = string.Empty;
        public string Description { set; get; } = string.Empty;
        public int Credit { set; get; }
        public int Semester { set; get; }

        public ICollection<Enrollment> Enrollments { set; get; } = new List<Enrollment>();
    }
}