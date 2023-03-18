
namespace Online_learning.Entities
{
    public class Assignments
    {
        public int Id { get; set; }
        public string AssignmentsName { get; set; }
        public int NumberOfPoint { get; set;}
        public DateTime DeadLine { get; set; }
        public int StudentId { get; set; }
        public Students Student { get; set; }
        public int CourseId { get; set; }
        public Courses Course { get; set; }
        public Grades Grade { get; set; }
    }
}
