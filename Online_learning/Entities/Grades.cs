
namespace Online_learning.Entities
{
    public class Grades
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public int StudentId { get; set; }
        public Students Student { get; set; }
        public int AssignmentId { get; set; }
        public Assignments Assignment { get; set; }
    }
}
