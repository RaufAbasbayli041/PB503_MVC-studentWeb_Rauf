namespace StudentWEB_rauf.Entity
{
    public class Course : BaseEntity
    {
        public int CodeName { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<CourseModule> Modules { get; set; }
        public ICollection<Exam> Exams { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teacher { get; set; }
    }
}
