namespace StudentWEB_rauf.DTO
{
    public record TeacherDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
