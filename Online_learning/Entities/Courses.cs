
namespace Online_learning.Entities
{
    public class Courses
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public string Teacher { get; set; }
        public int NumberOfStudents { get; set; }
        public int StudentId { get; set; }
        public Students Student { get; set; }
        public List<Assignments> Assignment { get; set; }
    }
}
