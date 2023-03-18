
using System.Net;

namespace Online_learning.Entities
{
    public class Students
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public List<Courses> Course { get; set; }
        public List<Assignments> Assignment { get; set; }
        public List<Grades> Grade { get; set; }
    }
}
