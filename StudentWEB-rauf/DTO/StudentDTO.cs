namespace StudentWEB_rauf.DTO
{
    public record StudentDTO : BaseDTO
    {
        public string StudentCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
       
    }
}
