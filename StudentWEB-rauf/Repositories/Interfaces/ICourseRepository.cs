using StudentWEB_rauf.Entity;

namespace StudentWEB_rauf.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        Task<Course> CreateCourseAsync(Course course);
        void UpdateCourseAsync(Course course);
        Task<List<Course>> GetAllCourseAsync();
        Task<Course> GetCourseByIdAsync(int id);

    }
}
