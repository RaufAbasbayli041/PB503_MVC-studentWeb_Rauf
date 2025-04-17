namespace StudentWEB_rauf.Entity
{
    public class CourseModule : BaseEntity
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Unit> Units { get; set; }
    }
}
