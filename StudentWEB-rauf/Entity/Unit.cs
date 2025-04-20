namespace StudentWEB_rauf.Entity
{
    public class Unit : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CourseModuleId { get; set; }
        public CourseModule CourseModule { get; set; }
    }
}
