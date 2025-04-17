using Microsoft.EntityFrameworkCore;
using StudentWEB_rauf.Entity;

namespace StudentWEB_rauf.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
              
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseModule> Modules { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Point> Points { get; set; }

    }
}
