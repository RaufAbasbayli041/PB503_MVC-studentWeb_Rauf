using StudentWEB_rauf.DTO;
using StudentWEB_rauf.Entity;

namespace StudentWEB_rauf.Services.Interfaces
{
    public interface ICourseModuleServices
    {
        Task<CourseModuleDTO> CreateModuleAsync(CourseModuleDTO courseModuleDTO);
        void UpdateModuleAync(CourseModuleDTO courseModuleDTO, int id);
        Task<List<CourseModuleDTO>> GetAllModulesAsync();
        Task<CourseModuleDTO> GetModuleByIdAync(int id);
    }
}
