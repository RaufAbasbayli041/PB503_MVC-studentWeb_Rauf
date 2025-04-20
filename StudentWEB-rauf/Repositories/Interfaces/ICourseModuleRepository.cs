using StudentWEB_rauf.Entity;

namespace StudentWEB_rauf.Repositories.Interfaces
{
    public interface ICourseModuleRepository
    {
        Task<CourseModule> CreateModuleAsync (CourseModule courseModule);
        void UpdateModuleAync (CourseModule courseModule);
        Task<List<CourseModule>> GetAllModulesAsync();
        Task<CourseModule> GetModuleByIdAync(int id);
    }
}
