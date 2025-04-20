namespace StudentWEB_rauf.DTO
{
    public record CourseModuleDTO : BaseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
