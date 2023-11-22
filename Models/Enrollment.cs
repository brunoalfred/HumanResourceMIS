using System.ComponentModel.DataAnnotations;



namespace HumanResourceMIS.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int ID { set; get; }
        public int StudentID { set; get; }
        public int CourseID { set; get; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { set; get; }
        public DateTime Date { set; get; }

        public required Student Student { set; get; }

        public required Course Course { set; get; }

    }
}