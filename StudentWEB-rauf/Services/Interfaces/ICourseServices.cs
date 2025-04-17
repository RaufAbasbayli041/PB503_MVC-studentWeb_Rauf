using StudentWEB_rauf.DTO;
using StudentWEB_rauf.Entity;

namespace StudentWEB_rauf.Services.Interfaces
{
    public interface ICourseServices
    {
        Task<CourseDTO> CreateCourseAsync(CourseDTO courseDto);
        Task UpdateCourseAsync(CourseDTO courseDto,int id);
        Task<List<CourseDTO>> GetAllCourseAsync();
        Task<CourseDTO> GetCourseByIdAsync(int id);
    }
}
