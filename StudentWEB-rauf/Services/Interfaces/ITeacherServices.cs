using StudentWEB_rauf.DTO;
using StudentWEB_rauf.Entity;

namespace StudentWEB_rauf.Services.Interfaces
{
    public interface ITeacherServices
    {
        Task<TeacherDTO> CreateTeacherAsync(TeacherDTO teacherDTO);
        void UpdateTeacherAsync(TeacherDTO teacherDTO, int id);
        Task<List<TeacherDTO>> GetAllTeacherAsync();
        Task<TeacherDTO> GetTeacherByIdAsync(int id);
    }
}
