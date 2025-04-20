using StudentWEB_rauf.Enum;

namespace StudentWEB_rauf.Entity
{
    public class Point : BaseEntity
    {

        public PointType PointType { get; set; }
        public decimal Result { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
