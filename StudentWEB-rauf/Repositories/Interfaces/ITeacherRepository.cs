using StudentWEB_rauf.Entity;

namespace StudentWEB_rauf.Repositories.Interfaces
{
    public interface ITeacherRepository
    {
        Task<Teacher> CreateTeacherAsync(Teacher teacher);
        void UpdateTeacherAsync(Teacher teacher);
        Task<List<Teacher>> GetAllTeacherAsync();
        Task<Teacher> GetTeacherByIdAsync(int id);

    }
}
