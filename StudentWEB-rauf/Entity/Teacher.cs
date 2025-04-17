namespace StudentWEB_rauf.Entity
{
    public class Teacher : Person
    {
        public double Salary { get; set; }
        public ICollection<Course>? Courses { get; set; }
    }
}
