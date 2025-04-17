using Microsoft.EntityFrameworkCore;
using StudentWEB_rauf.data;
using StudentWEB_rauf.Entity;
using StudentWEB_rauf.Repositories.Interfaces;

namespace StudentWEB_rauf.Repositories.Implementations
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _appDbContext;

        public CourseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Course> CreateCourseAsync(Course course)
        {
            await _appDbContext.Courses.AddAsync(course);
            await _appDbContext.SaveChangesAsync();
            return course;
        }

        public async Task<List<Course>> GetAllCourseAsync()
        {
            var items = await _appDbContext.Courses.ToListAsync();
            return items;
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            var data = await _appDbContext.Courses.FindAsync(id);
            return data;
        }

        public async void UpdateCourseAsync(Course course)
        {

            _appDbContext.Courses.Update(course);
            _appDbContext.SaveChanges();
        }
    }
}
