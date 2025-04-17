using System.Drawing;

namespace StudentWEB_rauf.Entity
{
    public class Student : Person
    {
        public string StudentId { get; set; }
        public double Grade { get; set; }
        public ICollection<Point> Points { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
