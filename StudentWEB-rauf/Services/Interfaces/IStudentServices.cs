using StudentWEB_rauf.DTO;
using StudentWEB_rauf.Entity;

namespace StudentWEB_rauf.Services.Interfaces
{
    public interface IStudentServices
    {
        Task<StudentDTO> CreateStudentAsync(StudentDTO studentDTO);
        void UpdateStudentAsync(StudentDTO studentDTO, int id);
        Task<List<StudentDTO>> GetAllStudentsAsync();
        Task<StudentDTO> GetStudentByIdAsync(int id);
    }
}
