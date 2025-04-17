namespace StudentWEB_rauf.Entity
{
    public class Unit : BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public CourseModule CourseModule { get; set; }
        public int CourseModuleId { get; set; }
    }
}
